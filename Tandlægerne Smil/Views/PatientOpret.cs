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
    public partial class PatientOpret : Form
    {

        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controlleren
        StartForm t = new StartForm();

        public PatientOpret()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _controller.Patient.OpretPatient(textBoxNavn, textBoxEfternavn, textBoxCPR, textBoxAdresse, textBoxPostnummer,
               textBoxTelefon);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void OpretPatient_Load(object sender, EventArgs e)
        {
        }
    }
}