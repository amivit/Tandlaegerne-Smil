using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        
        public BehandlingAfslut(int booking_ID)
        {
            InitializeComponent();
            this.booking_ID = booking_ID;
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
            LoadPatientInfo();
            LoadBehandlingerTilCombobox();
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
            var behandling = _global.Db.BehandlingDbs.ToList();
            int index = 0;


            foreach (var item in behandling)
            {
                comboBox_Behandlinger.Items.Add(behandling[index].Navn);
                index++;
            }
        }
        public void LoadPatientInfo()
        {
            var Patient = _global.Db.PatientDbs.ToList();
            var booking = _global.Db.BookingDbs.ToList();
            var behandlingsrum = _global.Db.BehandlingsrumDbs.ToList();
            var ansat = _global.Db.AnsatDbs.ToList();
        
            var PatientJoin = from b in booking
                              join p in Patient
                              on b.PatientId equals p.PatientId
                              join br in behandlingsrum
                              on b.LokaleId equals br.RumId
                              join a in ansat
                              on b.LægeId equals a.AnsatId

                              select new
                              {
                                  b.BookingId,
                                  p.PatientId,
                                  p.Fornavn,
                                  p.Efternavn,
                                  p.Adresse,
                                  p.Postnummer,
                                  p.Cpr,
                                  p.Telefon,
                                  br.RumNavn,
                                  b.Tidspunkt,
                                  lægeNavn = a.Fornavn + " "+ a.Efternavn
                              };

            var patientSort = (from r in PatientJoin
                               where r.BookingId == booking_ID
                               select r).ToList();

            textBox_PatientNr.Text = patientSort[0].PatientId.ToString();
            textBox_Fornavn.Text = patientSort[0].Fornavn;
            textBox_Efternanv.Text = patientSort[0].Efternavn;
            textBox_Cpr.Text = patientSort[0].Cpr;
            textBox_Adresse.Text = patientSort[0].Adresse;
            textBox_Postnr.Text = patientSort[0].Postnummer.ToString();
            textBox_Tlfnr.Text = patientSort[0].Telefon;
            textBox_Lokale.Text = patientSort[0].RumNavn;
            textBox_dato.Text = patientSort[0].Tidspunkt.ToString();
            textBox_Læge.Text = patientSort[0].lægeNavn;
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

            //Faktura oprettelse
            _controller.Faktura.opretFaktura(booking_ID);
            //Skift flag så patienten fjernes fra venteværlesrerseseses
            var tjekketind = _global.Db.BookingDbs.FirstOrDefault(b => b.BookingId == booking_ID);
            tjekketind.Ankommet = false;
            _global.Db.SaveChanges();

            string Afslutning = "Behandlingen af "+(textBox_Fornavn.Text + " " +textBox_Efternanv.Text)+" er nu afsluttet";
            Afslutning += Environment.NewLine;
            Afslutning += "Patientens Faktura kan findes under Patient ID: " +textBox_PatientNr.Text;
            MessageBox.Show(Afslutning,"Færdig!");
            
            this.Close();
        }

        public void OpdaterBehandlinger()
        {
            //Sletter tidligere behandlinger
            var behandlingslinje_ = _global.Db.BehandlingslinjerDbs.Where(b => b.BookingId == booking_ID).ToList();


            foreach (var linjer in behandlingslinje_)
            {
                _global.Db.BehandlingslinjerDbs.Remove(linjer);
            }
            //_global.LogSqlQuery();
            //_global.Db.SaveChanges();

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
            _global.LogSqlQuery();
            _global.Db.SaveChanges();
        }

		private void textBox_Efternanv_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
