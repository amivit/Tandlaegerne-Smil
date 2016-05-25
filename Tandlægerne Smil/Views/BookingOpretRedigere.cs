﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers;
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
        }

        private void buttonTilføj_Click(object sender, EventArgs e)
        {
            var behandling = _global.Db.BehandlingDbs.FirstOrDefault(b => b.Navn == comboBoxBehandling.Text);
            //Console.WriteLine(behandling.ToString());
            ListViewItem lvi = new ListViewItem(behandling.Navn);
            lvi.SubItems.Add(behandling.Pris.ToString());
            lvi.SubItems.Add(behandling.AnslåetTid.ToString());

            listViewBehandling.Items.Add(lvi);
        }

        private void dateTimeOnly_ValueChanged(object sender, EventArgs e) // TODO: fjerne sekunder
        {
        }

        private void buttonGemBooking_Click(object sender, EventArgs e)
        {
            _controller.Book.GemBooking(_patientId, this);
        }

        private void textBoxPatient_TextChanged(object sender, EventArgs e)
        {
        }
        //gør opret book kanppen Disabled
        private void listViewBehandling_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLæge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBehandling_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLokale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}