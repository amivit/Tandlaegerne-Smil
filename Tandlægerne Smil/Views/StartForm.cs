using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Views
{
    public partial class StartForm : Form
    {
        #region Console-Debugger

        [DllImport("kernel32.dll")] // Næste 6 linjer er for at skjule konsollen
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SwHide = 0;
        private const int SwShow = 5;

        #endregion Console-Debugger

        //test
        //private Global _global = new Global();

        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controlleren

        public StartForm()
        {
            InitializeComponent();
        }

        public void RefreshPatientView()
        {
            listViewPatienter.Items.Clear();

            //var patientList = Db.PatientDbs.ToList();
            //var Db2 = new smildb();
            using (var db = new smildb())
            {
                var patientList = db.PatientDbs.ToList();

                // Db.Entry(Db.PatientDbs).Reload();
                foreach (var patientDb in patientList)
                {
                    ListViewItem lvi = new ListViewItem(patientDb.Fornavn.Replace(" ", string.Empty));
                    lvi.SubItems.Add(patientDb.Efternavn.Replace(" ", string.Empty));
                    lvi.SubItems.Add(patientDb.Telefon);
                    lvi.SubItems.Add(patientDb.PatientId.ToString());
                    lvi.Group = listViewPatienter.Groups[0];
                    listViewPatienter.Items.Add(lvi);
                }
            }
        }

        public void RefreshBookingView()
        {
            listViewDagensProgram.Items.Clear();
            using (var db = new smildb())
            {
                var dagensBookinger = db.BookingDbs
                    .Include(b => b.BehandlingslinjerDbs)
                    .Where(b => b.Tidspunkt.Day == dateTimePicker.Value.Day) // Kun den valgte dag
                    .OrderBy(b => b.Tidspunkt) // Sortere dem i rækkefølge
                    .ToList();

                foreach (var booking in dagensBookinger)
                {
                    ListViewItem list = new ListViewItem(booking.Tidspunkt.Hour.ToString() + ":" + booking.Tidspunkt.Minute.ToString());
                    var behandlinger = db.BehandlingDbs.Where(b => b.BehandlingslinjerDb.BookingId == booking.BookingId).ToList();
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
                    var behandlingslinjen = db.BehandlingslinjerDbs.FirstOrDefault(b => booking.BookingId == b.BookingId);

                    if (behandlingslinjen?.FakturaId != null)
                    {
                        list.BackColor = Color.LimeGreen;
                    }
                    else if (booking.Akut == true && behandlingslinjen?.FakturaId == null)
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

        public void RefreshVenteværelseView()
        {
            listViewVenteværelse.Items.Clear();
            using (var db = new smildb())
            {
                var venteVærelse = db.BookingDbs
                    .Where(b => b.Ankommet == true) // Kun den valgte dag
                    .OrderBy(b => b.Tidspunkt) // Sortere dem i rækkefølge
                    .ToList();
                foreach (var booking in venteVærelse)
                {
                    ListViewItem lvi = new ListViewItem(booking.Tidspunkt.ToString());
                    var behandlinger = db.BehandlingDbs.Where(b => b.BehandlingslinjerDb.BookingId == booking.BookingId).ToList();
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

                    if (booking.Behandlingstatus == true)
                    {
                        lvi.BackColor = Color.Yellow;
                    }
                    if (booking.AnsatDb != null)
                        lvi.SubItems.Add(booking.AnsatDb.Fornavn + " " + booking.AnsatDb.Efternavn);
                    else lvi.SubItems.Add("Akut");

                    lvi.SubItems.Add(totalAnslåetTid.ToString());
                    if (booking.BehandlingsrumDb != null)
                        lvi.SubItems.Add(booking.BehandlingsrumDb.RumNavn);
                    else lvi.SubItems.Add("Akut");
                    lvi.SubItems.Add(booking.PatientDb.Fornavn + " " + booking.PatientDb.Efternavn);
                    lvi.SubItems.Add(behandlingString);
                    lvi.SubItems.Add(booking.BookingId.ToString());
                    listViewVenteværelse.Items.Add(lvi);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)// Afslut af behandling knap
        {
            int bookingID = Convert.ToInt32(listViewVenteværelse.SelectedItems[0].SubItems[6].Text);
            //converter tekste i listview (booking id) til en int32 for den kan bruges i behandlings klassns constructor
            BehandlingAfslut BehandlingAfslut = new BehandlingAfslut(bookingID, this);
            //en instans af Afslut behandling oprettes med booking id og main formen
            BehandlingAfslut.ShowDialog();
            //åbner Afslut behandlings vinduet med en dialog så man kun kan åbne et vindu ad gangen
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPatientNavn = listViewDagensProgram.SelectedItems[0].SubItems[4].Text;
                if (MessageBox.Show("Skal " + selectedPatientNavn + " tjekkes ind?",
                        "Patient tjek-ind",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new smildb())
                    {
                        int bookingID = Convert.ToInt32(listViewDagensProgram.SelectedItems[0].SubItems[6].Text);
                        var tjekketind = db.BookingDbs.FirstOrDefault(b => b.BookingId == bookingID);
                        tjekketind.Ankommet = true;
                        db.SaveChanges();
                        RefreshVenteværelseView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),
                     "Fejl",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void listViewDagensProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            // User-Experience feature, så man slet ikke KAN klikke på de relevant knapper, hvis ikke noget i listviewet er markeret.
            if (listViewDagensProgram.SelectedItems.Count > 0)
            {
                buttonTjekkeInd.Enabled = true;
                buttonSletbooking.Enabled = true;
            }
            else
            {
                buttonTjekkeInd.Enabled = false;
                buttonSletbooking.Enabled = false;
                buttonUnderBehandling.Enabled = false;
                buttonAfslutBehandling.Enabled = false;
            }
        }

        private void buttonOpretPatient_Click(object sender, EventArgs e)
        {
            PatientOpret OP = new PatientOpret(this);
            OP.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Dette program er udviklet til Tandlægerne Smil af:
Nikolaj Kiil, Kasper Skov, Patrick Korsgaard & Paul Wittig", @"Version 0.0.1");
        }

        private void AfslutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            RefreshPatientView();
            RefreshBookingView();
            RefreshVenteværelseView();
        }

        private void VisKonsolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var handle = GetConsoleWindow();
            if (gemVisKonsolToolStripMenuItem.Checked)
            {
                ShowWindow(handle, SwHide);
                gemVisKonsolToolStripMenuItem.Checked = false;
            }
            else
            {
                ShowWindow(handle, SwShow);
                gemVisKonsolToolStripMenuItem.Checked = true;
            }
        }

        private void buttonUdskrivDagensBookninger_Click(object sender, EventArgs e)
        {
            _controller.Book.GemDagensProgram(this);
        }

        private void buttonRedigerePatient_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientID = Convert.ToInt32(listViewPatienter.SelectedItems[0].SubItems[3].Text);
                PatientRedigere PR = new PatientRedigere(PatientID, this);
                PR.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg en patient",
                    "Fejl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //*******************************************FAKTURA**********************************************

        #region faktura

        private void tabLiveView_Click(object sender, EventArgs e)
        {
        }

        private void udskrivFaktura_Click(object sender, EventArgs e)
        {
            try
            {
                string patientnavn = listView_Faktura.SelectedItems[0].SubItems[1].Text;
                int patientid = int.Parse(listView_Faktura.SelectedItems[0].SubItems[2].Text);
                int fakturaNR = int.Parse(listView_Faktura.SelectedItems[0].SubItems[0].Text);
                _controller.Faktura.UdskrivFaktura(fakturaNR, patientid, patientnavn);
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg en Faktura",
                     "Fejl",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //Søg
        {
            try
            {
                listView_Faktura.Items.Clear();
                _controller.Faktura.HentFaktura(int.Parse(textBox_PatientID.Text), listView_Faktura);
            }
            catch
            {
                MessageBox.Show("Fejl i Patient ID prøv igen");
            }
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void listView_Faktura_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button_VisAllePatienter_Click(object sender, EventArgs e)
        {
            int idNummer = 0;
            try
            {
                listView_Faktura.Items.Clear();
                foreach (var item in listView_Faktura.Items.ToString())
                {
                    _controller.Faktura.HentFaktura(idNummer, listView_Faktura);
                    idNummer++;
                }
            }
            catch
            {
                MessageBox.Show("Kunne ikke hente data");
            }
        }

        private void tabFaktura_Click(object sender, EventArgs e)
        {
        }

        private void button_VisAlleFolk_Click(object sender, EventArgs e)
        {
            FakturaPatienter F = new FakturaPatienter(this);
            F.Show();
        }

        private void listViewPatienter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // User-Experience feature, så man slet ikke KAN klikke på opret booking / redigere patient, hvis ikke en patient er markeret.
            if (listViewPatienter.SelectedItems.Count > 0)
            {
                buttonRedigerePatient.Enabled = true;
                buttonOpretBooking.Enabled = true;
                buttonUnderBehandling.Enabled = true;
            }
            else
            {
                buttonRedigerePatient.Enabled = false;
                buttonOpretBooking.Enabled = false;
                buttonUnderBehandling.Enabled = false;
            }
        }

        private void listViewVenteværelse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // User-Experience feature, så man slet ikke KAN klikke på de relevant knapper, hvis ikke noget i listviewet er markeret.
            if (listViewVenteværelse.SelectedItems.Count > 0)
            {
                buttonUnderBehandling.Enabled = true;
                buttonAfslutBehandling.Enabled = true;
            }
            else
            {
                buttonUnderBehandling.Enabled = false;
                buttonAfslutBehandling.Enabled = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void textBox_PatientID_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_VisDetaljer_Click(object sender, EventArgs e)
        {
            try //viser faktura detaljer
            {
                _controller.Faktura.HentOplysningerPåValgteFakatura(
                int.Parse(listView_Faktura.SelectedItems[0].SubItems[0].Text), listView_FakturaDetaljer);
                //Sender faktura nr. + listviewet faktura detaljer så vi kan tilføje linjer i faktura klassen (Y)
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg en Faktura",
                     "Fejl",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        #endregion faktura

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshBookingView();
        }

        private void buttonOpretBooking_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientID = Convert.ToInt32(listViewPatienter.SelectedItems[0].SubItems[3].Text);
                BookingOpretRedigere bookingOpretRedigere = new BookingOpretRedigere(PatientID, this);
                bookingOpretRedigere.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Vælg en patient",
                     "Fejl",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void buttonSletbooking_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker på at du vil slette valgte booking", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int bookingID = Convert.ToInt32(listViewDagensProgram.SelectedItems[0].SubItems[6].Text);
                    _controller.Book.SletBooking(bookingID);
                    RefreshBookingView();
                    RefreshVenteværelseView();
                }
                catch (Exception)
                {
                    MessageBox.Show("Vælg booking",
                       "Fejl",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUnderBehandling_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingID = Convert.ToInt32(listViewVenteværelse.SelectedItems[0].SubItems[6].Text);
                _controller.Venteværelse.MarkereSomUnderBehandling(bookingID);
                RefreshVenteværelseView();
            }
            catch (Exception)
            {
                
            }
        }

        private void buttonRedigereBookning_Click(object sender, EventArgs e)
        {
        }

        private void buttonAkutAnkomst_Click(object sender, EventArgs e)
        {
            AkutPatient akutPatientForm = new AkutPatient(this);
            akutPatientForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            RefreshAlt();
        }

        public void RefreshAlt()
        {
            RefreshPatientView();
            RefreshBookingView();
            RefreshVenteværelseView();
        }

        private void demotilstandToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}