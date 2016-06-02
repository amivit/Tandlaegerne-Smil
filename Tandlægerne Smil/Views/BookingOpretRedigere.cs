using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Infrastructure;
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
	public partial class BookingOpretRedigere : Form
	{
		private StartForm _startForm;
		private readonly int _patientId;
		private readonly Controller _controller = new Controller(); // Så vores view kan snakke med controllerenPatient P = new Patient();
		private Global _global = new Global();

		public BookingOpretRedigere(int patientId, StartForm startForm)
		{
			this._patientId = patientId;
			this._startForm = startForm;
			InitializeComponent();
			_controller.Book.LoadOpretBooking(patientId, this);
		}

		private void BookingOpretRedigere_Load(object sender, EventArgs e)
		{
			try
			{
				var Patient = _global.Db.PatientDbs;

				var patientSort = (from p in Patient
								   where p.PatientId == _patientId
								   select p).ToList();

				if (patientSort[0].Tandlægeskræk.Value == true)
				{
					labelTandlægeSkræk.Text = "Har tandlægeskræk";
				}
				else
				{
					labelTandlægeSkræk.Text = "";
				}
			}
			catch (Exception)
			{
				
				throw;
			}
			

		}

		private void buttonTilføj_Click(object sender, EventArgs e)
		{
            try
            {
                var behandling = _global.Db.BehandlingDbs.FirstOrDefault(b => b.Navn == comboBoxBehandling.Text);
                //Console.WriteLine(behandling.ToString());
                ListViewItem lvi = new ListViewItem(behandling.Navn);
                lvi.SubItems.Add(behandling.Pris.ToString());
                lvi.SubItems.Add(behandling.AnslåetTid.ToString());
                listViewBehandling.Items.Add(lvi);

                if (comboBoxLæge.SelectedIndex > 0 && comboBoxBehandling.SelectedIndex > 0 & comboBoxLokale.SelectedIndex > 0 && listViewBehandling.Items.Count > 0)
                {
                    buttonGemBooking.Enabled = true;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ingen behandling valgt.",
                                "Advarsel",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

            }
		}

		private void dateTimeOnly_ValueChanged(object sender, EventArgs e) // TODO: fjerne sekunder
		{
		}

		private void buttonGemBooking_Click(object sender, EventArgs e)
		{
			_controller.Book.GemBooking(_patientId, this);
			_startForm.RefreshBookingView();
		}

		private void textBoxPatient_TextChanged(object sender, EventArgs e)
		{
		}

		private void buttonSletBehandling_Click(object sender, EventArgs e)
		{
			try
			{
				listViewBehandling.SelectedItems[0].Remove();
				
			}
			catch (Exception)
			{
                MessageBox.Show("Ingen behandling valgt.",
                                "Advarsel",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
		
		}
		//gør opret book kanppen Disabled
		private void listViewBehandling_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxLæge.SelectedIndex > 0 && comboBoxBehandling.SelectedIndex > 0 & comboBoxLokale.SelectedIndex > 0 && listViewBehandling.Items.Count > 0)
			{
				buttonGemBooking.Enabled = true;
			}
			
		}

		private void comboBoxLæge_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxLæge.SelectedIndex > 0 && comboBoxBehandling.SelectedIndex > 0 & comboBoxLokale.SelectedIndex > 0 && listViewBehandling.Items.Count > 0)
			{
				buttonGemBooking.Enabled = true;
			}
		}

		private void comboBoxBehandling_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (comboBoxLæge.SelectedIndex > 0 && comboBoxBehandling.SelectedIndex > 0 & comboBoxLokale.SelectedIndex > 0 && listViewBehandling.Items.Count > 0)
			{
				buttonGemBooking.Enabled = true;
			}
		}

		private void comboBoxLokale_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxLæge.SelectedIndex > 0 && comboBoxBehandling.SelectedIndex > 0 & comboBoxLokale.SelectedIndex > 0 && listViewBehandling.Items.Count > 0)
			{
				buttonGemBooking.Enabled = true;
			}
		}
	}
}