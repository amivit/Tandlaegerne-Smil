﻿using System;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Venteværelse : Global
    {
        private readonly BookingDb _bookingDb = new BookingDb();
        private readonly VenteværelseDb _venteværelseDb = new VenteværelseDb();

        

        public void MarkereSomUnderBehandling(int bookingID)
		{ //****KODET AF: KASPER & PAUL****
			try
            {
                if (MessageBox.Show("Skal den valgte booking markeres som underbehandling?",
                "Underbehandling",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var venteværelseBooking = Db.BookingDbs.FirstOrDefault(b => b.BookingId == bookingID);
                    venteværelseBooking.Behandlingstatus = true;
                    Db.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl",
                        "Fejl",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}