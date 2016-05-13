using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Models;

namespace Tandlægerne_Smil.Views
{
    public partial class OpretPatient : Form
    {
        Patient P = new Patient();
        public OpretPatient()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                P.OpretPatient(textBoxNavn, textBoxEfternavn, textBoxCPR, textBoxAdresse, textBoxPostnummer,
                    textBoxTelefon);
                MessageBox.Show("Patient oprettet");

            }
            catch (Exception)
            {

                MessageBox.Show("Fejl i input",
                    "Fejl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
     
        }
    }
}
