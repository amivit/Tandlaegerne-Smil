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
        readonly int _patientId;
        private StartForm _startForm;
        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controllerenPatient P = new Patient();
        public PatientRedigere(int PatientID, StartForm startForm)
        {
            InitializeComponent();
            this._patientId = PatientID;
            this._startForm = startForm;
            _controller.Patient.LoadRedigerePatient(_patientId, this);

        }

        private void PatientRedigere_Load(object sender, EventArgs e)
        {
            //_controller.Patient.LoadOpretBooking(Convert.ToInt32(PatientID), this);
        }

        private void Slet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Er du sikker på at du vil slette valgte patient", "Advarsel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _controller.Patient.SletPatient(Convert.ToInt32(_patientId));
                _startForm.RefreshPatientView();
            }
        }

        private void Afslut_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void Gem_Click(object sender, EventArgs e)
        {
            _controller.Patient.RedigerePatientGem(_patientId, this);
            _startForm.RefreshPatientView();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
