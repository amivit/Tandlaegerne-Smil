using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void HentDagensProgram()
        {
            throw new System.NotImplementedException();
        }

        public void GemDagensProgram()
        {
            throw new System.NotImplementedException();
        }
    }
}