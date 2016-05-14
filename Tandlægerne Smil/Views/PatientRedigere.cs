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
    public partial class PatientRedigere : Form
    {
        string PatientNavn;
        string PatientEfternavn;
        string PatientTelefon;
        string PatientID;
        Patient P = new Patient();
        

        public PatientRedigere(string PatientNavn, string PatientEfternavn, string PatientTelefon,string PatientID)
        {
            InitializeComponent();
            this.PatientNavn = PatientNavn;
            this.PatientEfternavn = PatientEfternavn;
            this.PatientTelefon = PatientTelefon;
            this.PatientID = PatientID;
        }

        private void PatientRedigere_Load(object sender, EventArgs e)
        {
            textBoxNavn.Text = PatientNavn;
            textBoxEfternavn.Text = PatientEfternavn;
            textBoxTelefon.Text = PatientTelefon;
            textBoxID.Text = PatientID;
        }

        private void Slet_Click(object sender, EventArgs e)
        {
            P.SletPatient(Convert.ToInt32(PatientID));
        }
    }
}
