using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers;
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Models;

namespace Tandlægerne_Smil.Views
{
    public partial class BookingOpretRedigere : Form
	{ //****KODET AF: PATRICK, NIKOLAJ & PAUL****
		private StartForm _startForm;
        private readonly int _patientId;
        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controllerenPatient P = new Patient();
        private Global _global = new Global();

        public BookingOpretRedigere(int patientId, StartForm startForm)
        {
            this._patientId = patientId;
            this._startForm = startForm;
            InitializeComponent();
            _controller.Book.LoadOpretBooking(patientId, this);
        }

        private void BookingOpretRedigere_Load(object sender, EventArgs e)
        {
            dateTimeOnlyPicker.MinDate = DateTime.Parse("8:30:00");
            dateTimeOnlyPicker.MaxDate = DateTime.Parse("16:00:00");
            RefreshBookingView();

            try
            {
                var Patient = _global.Db.PatientDbs;

                var patientSort = (from p in Patient
                                   where p.PatientId == _patientId
                                   select p).ToList();

                if (patientSort[0].Tandlægeskræk.Value == true)
                {
                    labelTandlægeSkræk.Text = "Har tandlægeskræk";
                }
                else
                {
                    labelTandlægeSkræk.Text = "";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void buttonTilføj_Click(object sender, EventArgs e)
        {
            try
            {
                var behandling = _global.Db.BehandlingDbs.FirstOrDefault(b => b.Navn == comboBoxBehandling.Text);
                //Console.WriteLine(behandling.ToString());
                ListViewItem lvi = new ListViewItem(behandling.Navn);
                lvi.SubItems.Add(behandling.Pris.ToString());
                lvi.SubItems.Add(behandling.AnslåetTid.ToString());
                listViewBehandling.Items.Add(lvi);

                if (comboBoxLæge.SelectedIndex > 0 && comboBoxBehandling.SelectedIndex > 0 & comboBoxLokale.SelectedIndex > 0 && listViewBehandling.Items.Count > 0)
                {
                    buttonGemBooking.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingen behandling valgt.",
                                "Advarsel",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dateTimeOnly_ValueChanged(object sender, EventArgs e) // TODO: fjerne sekunder
        {
        }

        private void buttonGemBooking_Click(object sender, EventArgs e)
        {
            _controller.Book.GemBooking(_patientId, this);
            _startForm.RefreshBookingView();
        }

        private void textBoxPatient_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonSletBehandling_Click(object sender, EventArgs e)
        {
            try
            {
                listViewBehandling.SelectedItems[0].Remove();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingen behandling valgt.",
                                "Advarsel",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //gør opret book kanppen Disabled
        private void listViewBehandling_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLæge.SelectedIndex >= 0 && comboBoxBehandling.SelectedIndex >= 0 & comboBoxLokale.SelectedIndex >= 0 && listViewBehandling.Items.Count >= 0)
            {
                buttonGemBooking.Enabled = true;
            }
        }

        private void comboBoxLæge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLæge.SelectedIndex >= 0 && comboBoxBehandling.SelectedIndex >= 0 & comboBoxLokale.SelectedIndex >= 0 && listViewBehandling.Items.Count >= 0)
            {
                buttonGemBooking.Enabled = true;
            }
        }

        private void comboBoxBehandling_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLæge.SelectedIndex >= 0 && comboBoxBehandling.SelectedIndex >= 0 & comboBoxLokale.SelectedIndex >= 0 && listViewBehandling.Items.Count >= 0)
            {
                buttonGemBooking.Enabled = true;
            }
        }

        private void comboBoxLokale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLæge.SelectedIndex >= 0 && comboBoxBehandling.SelectedIndex >= 0 & comboBoxLokale.SelectedIndex >= 0 && listViewBehandling.Items.Count >= 0)
            {
                buttonGemBooking.Enabled = true;
            }
        }

        public void RefreshBookingView()
        {
            listViewDagensProgram.Items.Clear();
            listViewDagensProgram.Items.Clear();
            using (var db = new smildb())
            {
                var dagensBookinger = db.BookingDbs
                    .Include(b => b.BehandlingslinjerDbs)
                    .Where(b => b.Tidspunkt.Day == datePicker.Value.Day) // Kun den valgte dag
                    .OrderBy(b => b.Tidspunkt) // Sortere dem i rækkefølge
                    .ToList();

                foreach (var booking in dagensBookinger)
                {
                    ListViewItem list = new ListViewItem(booking.Tidspunkt.Hour.ToString() + ":" + booking.Tidspunkt.Minute.ToString());
                    var behandlinger = db.BehandlingDbs.Where(b => b.BehandlingslinjerDbs.Any(bb => bb.BookingId == booking.BookingId)).ToList();
                    var behandlingString = "";
                    var totalAnslåetTid = 0;
                    if (behandlinger.Count > 0) // Hvis der overhovedet er nogle behandlinger tilknyttede bookingen, så man ikke får fejl
                    {
                        behandlingString = behandlinger[0].Navn;
                        totalAnslåetTid = behandlinger[0].AnslåetTid;
                    }
                    foreach (var behandling in behandlinger.Skip(1)) // Spring den første over, og tilføje alle behandlinger (hvis der er nogle)
                    {
                        behandlingString += ", " + behandling.Navn;
                        totalAnslåetTid += behandling.AnslåetTid;
                    }
                    var behandlingslinjen = db.BehandlingslinjerDbs.FirstOrDefault(b => b.BookingId == booking.BookingId);

                    if (booking.Faktureret == true)
                    {
                        list.BackColor = Color.LimeGreen;
                    }
                    else if (booking.Akut == true && booking.Faktureret != true)
                    {
                        list.BackColor = Color.Red;
                    }

                    if (booking.AnsatDb != null) list.SubItems.Add(booking.AnsatDb.Fornavn + " " + booking.AnsatDb.Efternavn);
                    else list.SubItems.Add("Akut");

                    list.SubItems.Add(totalAnslåetTid.ToString());

                    if (booking.BehandlingsrumDb != null) list.SubItems.Add(booking.BehandlingsrumDb.RumNavn);
                    else list.SubItems.Add("");

                    list.SubItems.Add(booking.PatientDb.Fornavn + " " + booking.PatientDb.Efternavn);
                    list.SubItems.Add(behandlingString);
                    list.SubItems.Add(booking.BookingId.ToString());
                    listViewDagensProgram.Items.Add(list);
                }
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshBookingView();
        }
    }
}