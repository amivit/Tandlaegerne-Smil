using System;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers;
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Models;

namespace Tandlægerne_Smil.Views
{//****KODET AF: PATRICK****
	public partial class FakturaPatienter : Form
    {
        private Global _global = new Global();
        private readonly Controller _controller = new Controller();
        private StartForm startform;

        public FakturaPatienter(StartForm startform)
        {
            this.startform = startform;
            InitializeComponent();
        }

        private void FakturaPatienter_Load(object sender, EventArgs e)
        {
            using (var db = new smildb())
            {
                var patientList = db.PatientDbs.ToList();
                foreach (var patientDb in patientList)
                {
                    ListViewItem lvi = new ListViewItem(patientDb.Fornavn.Replace(" ", string.Empty) + " "
                        + patientDb.Efternavn.Replace(" ", string.Empty));
                    lvi.SubItems.Add(patientDb.PatientId.ToString());
                    lvi.Group = listView.Groups[0];
                    listView.Items.Add(lvi);
                }
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                startform.textBox_PatientID.Text = listView.SelectedItems[0].SubItems[1].Text;
                startform.Button_Søg.PerformClick();
                startform.listView_FakturaDetaljer.Items.Clear();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl",
                     "Fejl",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}