using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Views;

namespace Tandlægerne_Smil.Models
{
    internal class Book : Global
    {
        private readonly BookingDb _bookingDb = new BookingDb();

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

		public void LoadOpretBooking(int patientID, BookingOpretRedigere bookingOpretRedigere)
		{
			
			var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientID);
			bookingOpretRedigere.textBoxPatient.Text = patient.Fornavn + " " + patient.Efternavn;
			bookingOpretRedigere.textBoxNoter.Text = patient.Noter;

			
			var læger = Db.AnsatDbs.ToList();
			var lokaler = Db.BehandlingsrumDbs.ToList();
			var behandlinger = Db.BehandlingDbs.ToList();

			var indexNavn = 0;
			var indexRum = 0;
			var indexbehandlinger = 0;
			foreach (var item in Db.AnsatDbs)
			{

				bookingOpretRedigere.comboBoxLæge.Items.Add(læger[indexNavn].Fornavn + " " + læger[indexNavn].Efternavn);
				indexNavn ++;
			}
			foreach (var item in Db.BehandlingsrumDbs)
			{
				bookingOpretRedigere.comboBoxLokale.Items.Add(lokaler[indexRum].RumNavn);
				indexRum ++;
			}

			foreach (var item in Db.BehandlingDbs)
			{
				bookingOpretRedigere.comboBoxBehandling.Items.Add(behandlinger[indexbehandlinger].Navn);
				indexbehandlinger ++;
			}

		}

	   // public  GetBehandlingId(string behandlingText) // Denne metode tager det valgte behandling fra Dropdown-listen, og returnere ID på behandlingen
	   // {
		  //  var behandlingId = from b in Db.BehandlingDbs
			 //   where b.Navn == behandlingText
			 //   select b.BehandlingId;
				
				
				
				////Db.BehandlingDbs.FirstOrDefault(b => b.Navn == behandlingText);



		  //  return behandlingId;
	   // }
    }
}