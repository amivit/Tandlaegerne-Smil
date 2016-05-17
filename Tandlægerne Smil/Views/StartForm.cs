using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers;
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Models;

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
        #endregion

        //test
        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controlleren
       

        public StartForm()
        {
            InitializeComponent();
        }
        
        private void opretTestPatient_Click(object sender, EventArgs e)
        {
            RefreshPatientView();
        }

        public void RefreshPatientView()
        {
            listViewPatienter.Items.Clear();

            //var patientList = Db.PatientDbs.ToList();
            //var Db2 = new smildb();
            using (var db = new smildb())
            {
                var patientList = db.PatientDbs.ToList();

                var index = 0;
                // Db.Entry(Db.PatientDbs).Reload();
                foreach (var patientDb in patientList)
                {
                    ListViewItem lvi = new ListViewItem(patientList[index].Fornavn.Replace(" ", string.Empty));
                    lvi.SubItems.Add(patientList[index].Efternavn.Replace(" ", string.Empty));
                    lvi.SubItems.Add(patientList[index].Telefon);
                    lvi.SubItems.Add(patientList[index].PatientId.ToString());
                    listViewPatienter.Items.Add(lvi);
                    listViewPatienter.Items[index].Group = listViewPatienter.Groups[0];
                    index++;
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Denne knap skal åbne en ny form, hvor lægen kan opdatere fakturaen med behandlingen.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Denne knap sørger for en bookning registreres i venteværelset, når patient ankommer
            // "Indtast CPR-nummer eller markere en Bookning"
        }

        private void listViewDagensProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Her skal items farvemarkeres som grønt, når patienten er ankommet, og fjernes når patienten er færdigbehandlet
        }

        private void buttonOpretPatient_Click(object sender, EventArgs e)
        {
            PatientOpret OP = new PatientOpret();
            OP.Show();
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
            //
            _controller.Book.GemDagensProgram(this.dateTimePicker);
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


            #region faktura
        }
        
        private void tabLiveView_Click(object sender, EventArgs e)
        {

        }

        private void udskrivFaktura_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //Søg
        {
            try
            {
                listView_Faktura.Items.Clear();
                _controller.Faktura.hentFaktura(int.Parse(textBox_PatientID.Text), listView_Faktura);
            }
            catch
            {
                MessageBox.Show("Fejl i Patient ID prøv igen");
            }
            
            
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

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
					_controller.Faktura.hentFaktura(idNummer, listView_Faktura);
					idNummer ++;
				}
				
			}
			catch
			{
				MessageBox.Show("Kunne ikke hente data");
			}
			
			
		
			
		}
	}
}