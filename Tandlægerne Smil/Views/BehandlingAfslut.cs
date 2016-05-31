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

            // ======================================================================
            //var behandlingslinjer = _global.Db.BehandlingslinjerDbs.ToList();
            //var behandling = _global.Db.BehandlingDbs.ToList();


            //var blQuery = from bl in behandlingslinjer
            //    join b in behandling
            //        on bl.BehandlingId equals b.BehandlingId
            //    select new
            //    {
            //        booking_ID = bl.BookingId,
            //        bl.BehandlingId,
            //        b.Navn,
            //        b.Pris
            //    };

            //var sortedList = (from r in blQuery
            //                  where (r.booking_ID == booking_ID)
            //                  select r).ToList();

            //int index = 0;
            //foreach (var r in sortedList)
            //{
            //    ListViewItem lvi = new ListViewItem(sortedList[index].Navn);
            //    lvi.SubItems.Add(sortedList[index].Pris.ToString());

            //    listView_BehandlingsList.Items.Add(lvi);
            //    index++;
            //}






            //var behandlingslinjer = _global.Db.BehandlingslinjerDbs.ToList();
            //var behandlinger = _global.Db.BehandlingDbs.ToList();
            //var joined = from b in behandlingslinjer
            //             join bl in behandlinger
            //             on b.BehandlingId equals bl.BehandlingId
            //             select new
            //             {
            //                bId = b.BehandlingId,
            //                fId = b.FakturaId,
            //                 navn = bl.Navn,
            //                 bl.Pris,
            //                 b.BookingId

            //             };

            //var linjercount = (from g in behandlingslinjer
            //                   where (g.BookingId == booking_ID)
            //    select g).ToList();



            //var sortedList = (from r in joined
            //                  where (r.BookingId == booking_ID)
            //                  select r).ToList();

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

            

            var PatientJoin = from b in booking
                              join p in Patient
                                  on b.PatientId equals p.PatientId
                            
                              select new
                              {
                                  b.BookingId,
                                  p.PatientId,
                                  p.Fornavn,
                                  p.Efternavn,
                                  p.Adresse,
                                  p.Postnummer,
                                  p.Cpr,
                                  p.Telefon

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
        }

        private void button_TiljøjBehandling_Click(object sender, EventArgs e) //ADD behandling
        {
            var behandling = _global.Db.BehandlingDbs.FirstOrDefault(b => b.Navn == comboBox_Behandlinger.Text);
             
            ListViewItem lvi = new ListViewItem(behandling.Navn);
            lvi.SubItems.Add(behandling.Pris.ToString());
            
            listView_BehandlingsList.Items.Add(lvi);
        }
    }
}
