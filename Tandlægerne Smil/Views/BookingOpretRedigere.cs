using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tandlægerne_Smil.Views
{
    public partial class BookingOpretRedigere : Form
    {
        private StartForm _startForm;
        readonly int _patientId;

        public BookingOpretRedigere(int patientId, StartForm startForm)
        {
            this._patientId = patientId;
            this._startForm = startForm;
            InitializeComponent();
        }

        private void BookingOpretRedigere_Load(object sender, EventArgs e)
        {

        }
    }
}
