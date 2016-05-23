using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        //private readonly BookingDb _bookingDb = new BookingDb();

        public void GemDagensProgram(DateTimePicker dateTimePicker) // TODO: Gem dagens program
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
                indexNavn++;
            }
            foreach (var item in Db.BehandlingsrumDbs)
            {
                bookingOpretRedigere.comboBoxLokale.Items.Add(lokaler[indexRum].RumNavn);
                indexRum++;
            }

            foreach (var item in Db.BehandlingDbs)
            {
                bookingOpretRedigere.comboBoxBehandling.Items.Add(behandlinger[indexbehandlinger].Navn);
                indexbehandlinger++;
            }
        }

        public void GemBooking(int patientID, BookingOpretRedigere bookingOpretRedigere)
        {
            var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientID);

            //_bookingDb.Ankommet = false;
            var CreatedBooking = new BookingDb();

            // Match Læge fra combobox, med databasen. Fornavn og efternavn skal splittes, da de ligger i 2 forskellige kolonner i db'en
            var names = bookingOpretRedigere.comboBoxLæge.Text.Split(' ');
            string lægeFornavn = names[0];
            string lægeEfternavn = names[1];
            var læge = Db.AnsatDbs.FirstOrDefault(a => a.Fornavn == lægeFornavn && a.Efternavn == lægeEfternavn);
            CreatedBooking.AnsatDb = læge;

            // Match Lokale fra combobox, med lokale i databasen
            var lokale = Db.BehandlingsrumDbs.FirstOrDefault(b => b.RumNavn == bookingOpretRedigere.comboBoxLokale.Text);

            var date = bookingOpretRedigere.datePicker.Value;
            var time = bookingOpretRedigere.dateTimeOnlyPicker.Value;

            CreatedBooking.Tidspunkt = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, 0);
            //    bookingOpretRedigere.datePicker.Value;
            //bookingDb.Tidspunkt = bookingOpretRedigere.dateTimeOnlyPicker.Value;

            CreatedBooking.PatientId = patient.PatientId;
            CreatedBooking.LokaleId = lokale.RumId;

            var addedBooking = Db.BookingDbs.Add(CreatedBooking);
            LogSqlQuery();
            Db.SaveChanges(); // Opret bookingen inden vi tilføjer behandlinger til den

            for (int i = 0; i < bookingOpretRedigere.listViewBehandling.Items.Count; i++)
            {
                var behandlingsNavn = bookingOpretRedigere.listViewBehandling.Items[i].Text;
                var behandlingTemp = Db.BehandlingDbs.FirstOrDefault(b => b.Navn == behandlingsNavn);

                var linje = new BehandlingslinjerDb
                {
                    BookingDb = addedBooking,
                    BehandlingDb = behandlingTemp
                };
                Db.BehandlingslinjerDbs.Add(linje);
            }
            LogSqlQuery();
            Db.SaveChanges();
        }
    }
}