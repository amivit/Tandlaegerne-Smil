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
    public partial class FakturaPatienter : Form
    {
        Global _global = new Global();
        private readonly Controller _controller = new Controller();
        StartForm startform;

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
                var index = 0;
                foreach (var patientDb in patientList)
                {
                    ListViewItem lvi = new ListViewItem(patientList[index].Fornavn.Replace(" ", string.Empty)+" "
                        + patientList[index].Efternavn.Replace(" ", string.Empty));
                    lvi.SubItems.Add(patientList[index].PatientId.ToString());
                    
                    listView.Items.Add(lvi);
                    listView.Items[index].Group = listView.Groups[0];
                    index++;
                }
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            startform.textBox_PatientID.Text = listView.SelectedItems[0].SubItems[1].Text;
            startform.Button_Søg.PerformClick();
            startform.listView_FakturaDetaljer.Items.Clear();
            this.Close();

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
