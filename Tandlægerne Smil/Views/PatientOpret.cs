using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
    public partial class PatientOpret : Form
    {
        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controlleren
        private static StartForm _startForm;
        private static PatientOpret _instance;

        protected PatientOpret(StartForm startForm) // protected så man ikke længere kan benytte constructeren, men skal bruge metoden SingletonLazyInstance()
        {
            InitializeComponent();
            PatientOpret._startForm = startForm;
        }

        public static PatientOpret SingletonLazyInstance(StartForm _startForm)
        {
            // lazy initialization
            if (_instance == null)
            {
                _instance = new PatientOpret(_startForm);
            }
            return _instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.Patient.OpretPatient(textBoxNavn, textBoxEfternavn, textBoxCPR, textBoxAdresse, textBoxPostnummer,
               textBoxTelefon);
            _startForm.RefreshPatientView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpretPatient_Load(object sender, EventArgs e)
        {
        }

        private void textBoxCPR_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxAdresse_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxEfternavn_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}