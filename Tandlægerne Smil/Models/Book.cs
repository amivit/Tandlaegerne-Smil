using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Book : Global
    {
        private readonly BookingDb _bookingDb = new BookingDb();

        public void OpretBookning()
        {
            throw new System.NotImplementedException();
        }

        public void AkutAnkomst()
        {
            throw new System.NotImplementedException();
        }

        public void SletBookning()
        {
            throw new System.NotImplementedException();
        }

        public void GemDagensProgram(DateTimePicker dateTimePicker)
        {
            //Console.WriteLine(dateTimePicker.Value.Day);
            var index = 0;
            var bookings = Db.BookingDbs.ToList();
            Console.WriteLine(bookings[index].Tidspunkt.ToShortDateString());
        }
    }
}