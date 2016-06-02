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

namespace Tandlægerne_Smil.Views
{
    public partial class AkutPatient : Form
    {
        private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controlleren


        public AkutPatient()
        {
            InitializeComponent();
        }

        private void AkutPatient_Load(object sender, EventArgs e)
        {

            comboBoxTidspunkt.Items.Add("Akuttid NU");
            comboBoxTidspunkt.Items.Add("Morgen Akuttid 8:00");
            comboBoxTidspunkt.Items.Add("Eftermiddags Akuttid 16:30");

            using (var db = new smildb())
            {
                var patientList = db.PatientDbs.ToList();
                foreach (var patientDb in patientList)
                {
                    ListViewItem lvi = new ListViewItem(patientDb.Fornavn.Replace(" ", string.Empty) + " "
                        + patientDb.Efternavn.Replace(" ", string.Empty));
                    lvi.SubItems.Add(patientDb.PatientId.ToString());
                    lvi.Group = listViewPatient.Groups[0];
                    listViewPatient.Items.Add(lvi);
                }

                

                //foreach (var item in _controller.Book.AkutTider())
                //{
                //    comboBoxTidspunkt.Items.Add(item);
                //}
            }
        }

        private void buttonAkutpatient_Click(object sender, EventArgs e)
        {
            var patientId = Convert.ToInt32(listViewPatient.SelectedItems[0].SubItems[1].Text);
            _controller.Book.GemBookingAkut(patientId, this);
        }
    }
}