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
    }
}