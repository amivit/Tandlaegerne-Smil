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
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Models;

namespace Tandlægerne_Smil.Views
{
    public partial class PatientRedigere : Form
    {

        int PatientID;
        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controllerenPatient P = new Patient();
        StartForm S = new StartForm();
        

        public PatientRedigere(int PatientID)
        {
            InitializeComponent();
            this.PatientID = PatientID;
            _controller.Patient.LoadRedigerePatient(Convert.ToInt32(PatientID), this);

        }

        private void PatientRedigere_Load(object sender, EventArgs e)
        {
            //_controller.Patient.LoadRedigerePatient(Convert.ToInt32(PatientID), this);
        }

        private void Slet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker på at du vil slette valgte patient", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _controller.Patient.SletPatient(Convert.ToInt32(PatientID));
            }
           


        }

        private void Afslut_Click(object sender, EventArgs e)
        {
            
            // this.Close();
            
        }

        private void Gem_Click(object sender, EventArgs e)
        {
            _controller.Patient.RedigerePatientGem(PatientID, this);

        }
    }
}
