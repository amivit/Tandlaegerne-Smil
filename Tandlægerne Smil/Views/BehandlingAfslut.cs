using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers;
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Models;

namespace Tandlægerne_Smil.Views
{
    public partial class BehandlingAfslut : Form
    {
        private StartForm _startForm;

        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controllerenPatient P = new Patient();

        private Global _global = new Global();
        private int booking_ID;

        public BehandlingAfslut(int booking_ID, StartForm startForm)
        {
            InitializeComponent();
            this.booking_ID = booking_ID;
            this._startForm = startForm;
        }

        private void button1_Click(object sender, EventArgs e) //FJERN LINJE
        {
            try
            {
                listView_BehandlingsList.SelectedItems[0].Remove();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingen behandling valgt.",
                                "Advarsel",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BehandlingAfslut_Load(object sender, EventArgs e) //LOAD
        {
            LoadBehandlingerTilCombobox();
            LoadPatientInfo();
            LoadTidligereBehandlinger();
        }

        public void LoadTidligereBehandlinger()
        {
            var behandlingslinjer = _global.Db.BehandlingslinjerDbs
                    .Where(b => b.BookingId == booking_ID) // Kun den valgte dag
                    .ToList();
            foreach (var linje in behandlingslinjer)
            {
                var behandlinger = _global.Db.BehandlingDbs
                    .Where(b => b.BehandlingId == linje.BehandlingId) // Kun den valgte dag
                    .ToList();
                foreach (var behandling in behandlinger)
                {
                    ListViewItem list = new ListViewItem(behandling.Navn);
                    list.SubItems.Add(behandling.Pris.ToString());
                    listView_BehandlingsList.Items.Add(list);
                }
            }
        }

        public void LoadBehandlingerTilCombobox()
        {
            var behandlinger = _global.Db.BehandlingDbs.ToList();

            foreach (var item in behandlinger)
            {
                comboBox_Behandlinger.Items.Add(item.Navn);
            }
        }

        public void LoadPatientInfo()
        {
            var booking = _global.Db.BookingDbs.FirstOrDefault(b => b.BookingId == booking_ID);
            var patient = _global.Db.PatientDbs.FirstOrDefault(p => p.PatientId == booking.PatientId);
            var behandlingsrum = _global.Db.BehandlingsrumDbs.ToList();
            var ansat = _global.Db.AnsatDbs.ToList();

            //var patientJoin = from b in booking
            //                  join p in patient
            //                  on b.PatientId equals p.PatientId
            //                  join br in behandlingsrum
            //                  on b.LokaleId equals br.RumId
            //                  join a in ansat
            //                  on b.LægeId equals a.AnsatId

            //                  select new
            //                  {
            //                      b.BookingId,
            //                      p.PatientId,
            //                      p.Fornavn,
            //                      p.Efternavn,
            //                      p.Adresse,
            //                      p.Postnummer,
            //                      p.Cpr,
            //                      p.Telefon,
            //                      br.RumNavn,
            //                      b.Tidspunkt,
            //                      lægeNavn = a.Fornavn + " "+ a.Efternavn
            //                  };

            //var patientSort = (from r in patientJoin
            //                   where r.BookingId == booking_ID
            //                   select r).ToList();

            textBox_PatientNr.Text = patient.PatientId.ToString();
            textBox_Fornavn.Text = patient.Fornavn;
            textBox_Efternanv.Text = patient.Efternavn;
            textBox_Cpr.Text = patient.Cpr;
            textBox_Adresse.Text = patient.Adresse;
            textBox_Postnr.Text = patient.Postnummer.ToString();
            textBox_Tlfnr.Text = patient.Telefon;
            //textBox_Lokale.Text = booking.BehandlingsrumDb.RumNavn;
            //textBox_dato.Text = booking.Tidspunkt.ToString();
            //textBox_Læge.Text = booking.AnsatDb.Fornavn + " " + booking.AnsatDb.Efternavn;
        }

        private void button_TiljøjBehandling_Click(object sender, EventArgs e) //ADD behandling
        {
            var behandling = _global.Db.BehandlingDbs.FirstOrDefault(b => b.Navn == comboBox_Behandlinger.Text);

            ListViewItem lvi = new ListViewItem(behandling.Navn);
            lvi.SubItems.Add(behandling.Pris.ToString());

            listView_BehandlingsList.Items.Add(lvi);
        }

        private void button_GemOgFaktur_Click(object sender, EventArgs e)
        {
            OpdaterBehandlinger();
            if (listView_BehandlingsList.Items.Count != 0)
            {
                //Faktura oprettelse
                _controller.Faktura.OpretFaktura(booking_ID);
                //Skift flag så patienten fjernes fra venteværlesrerseseses
                var tjekketind = _global.Db.BookingDbs.FirstOrDefault(b => b.BookingId == booking_ID);
                tjekketind.Ankommet = false;
                _global.Db.SaveChanges();

                string Afslutning = "Behandlingen af " + (textBox_Fornavn.Text + " " + textBox_Efternanv.Text) + " er nu afsluttet";
                Afslutning += Environment.NewLine;
                Afslutning += "Patientens Faktura kan findes under Patient ID: " + textBox_PatientNr.Text;
                MessageBox.Show(Afslutning, "Færdig!");
                _startForm.RefreshVenteværelseView();
                _startForm.RefreshBookingView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tilføje nogle behandlingslinjer",
                    "Fejl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void OpdaterBehandlinger()
        {
            //Sletter tidligere behandlinger
            var behandlingslinje_ = _global.Db.BehandlingslinjerDbs.Where(b => b.BookingId == booking_ID).ToList();

            foreach (var linjer in behandlingslinje_)
            {
                _global.Db.BehandlingslinjerDbs.Remove(linjer);
            }
            _global.UdskrivSqlTilKonsol();
            _global.Db.SaveChanges();

            //opretter linjer fra listview (virker?)

            for (int i = 0; i < listView_BehandlingsList.Items.Count; i++)
            {
                var behandlingsNavn = listView_BehandlingsList.Items[i].Text;
                var behandlingTemp = _global.Db.BehandlingDbs.FirstOrDefault(b => b.Navn == behandlingsNavn);

                var linje = new BehandlingslinjerDb
                {
                    BookingId = booking_ID,
                    BehandlingDb = behandlingTemp
                };
                _global.Db.BehandlingslinjerDbs.Add(linje);
            }

            _global.UdskrivSqlTilKonsol();
            _global.Db.SaveChanges();
        }

        private void textBox_Efternanv_TextChanged(object sender, EventArgs e)
        {
        }
    }
}