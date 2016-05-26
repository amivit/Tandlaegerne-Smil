using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Venteværelse : Global
    {
        private readonly BookingDb _bookingDb = new BookingDb();
        private readonly VenteværelseDb _venteværelseDb = new VenteværelseDb();

        public void TjekkeInd(PatientDb patientDb)
        {
            throw new System.NotImplementedException();
        }

        public void MarkereSomUnderBehandling(int bookingID)
        {
            var venteværelseBooking = Db.BookingDbs.FirstOrDefault(b => b.BookingId == bookingID);

            
        }
    }
}