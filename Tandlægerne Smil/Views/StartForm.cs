using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers;

namespace Tandlægerne_Smil.Views
{
    public partial class StartForm : Form
    {
        private Controller controller = new Controller();

        public StartForm()
        {
            InitializeComponent();
        }

        private void opretTestPatient_Click(object sender, EventArgs e)
        {
            controller.Patient.OpretTestPatient();
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
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Dette program er udviklet til Tandlægerne Smil af:
Nikolaj Kiil, Kasper Skov, Patrick Korsgaard & Paul Wittig", @"Version 0.0.1");
        }

        private void afslutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}