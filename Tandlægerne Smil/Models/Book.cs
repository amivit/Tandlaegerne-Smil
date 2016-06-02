using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
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

        public void GemDagensProgram(StartForm _startForm) // TODO: Gem dagens program
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            var dato = _startForm.dateTimePicker.Value;
            sfd.FileName = ("Dagens-Program_" + dato.Day + "-" + dato.Month + "-" + dato.Year);
            //Taget fra http://stackoverflow.com/questions/14449407/writing-a-text-file-using-c-sharp
            sfd.FilterIndex = 1;

            StreamWriter sw = null;

            using (var db = new smildb())
            {
                var dagensBookinger = db.BookingDbs
                    .Include(b => b.BehandlingslinjerDbs)
                    .Where(b => b.Tidspunkt.Day == _startForm.dateTimePicker.Value.Day) // Kun den valgte dag
                    .OrderBy(b => b.Tidspunkt) // Sortere dem i rækkefølge
                    .ToList();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (sw = new StreamWriter(sfd.FileName))
                        try
                        {
                            sw.WriteLine("Tandlægernes Smil dagsprogram for den " + _startForm.dateTimePicker.Value.Day +
                                         "/" + _startForm.dateTimePicker.Value.Month);
                            sw.WriteLine("");
                            sw.WriteLine(
                                "======================================================================================");
                            sw.WriteLine("");
                            foreach (var booking in dagensBookinger)
                            {
                                var behandlinger =
                                    db.BehandlingDbs.Where(b => b.BehandlingslinjerDb.BookingId == booking.BookingId)
                                        .ToList();
                                var behandlingString = "";
                                var totalAnslåetTid = 0;

                                if (behandlinger.Count > 0)
                                // Hvis der overhovedet er nogle behandlinger tilknyttede bookingen, så man ikke får fejl
                                {
                                    behandlingString = behandlinger[0].Navn;
                                    totalAnslåetTid = behandlinger[0].AnslåetTid;
                                }
                                foreach (var behandling in behandlinger.Skip(1))
                                // Spring den første over, og tilføje alle behandlinger (hvis der er nogle)
                                {
                                    behandlingString += ", " + behandling.Navn;
                                    totalAnslåetTid += behandling.AnslåetTid;
                                }

                                sw.WriteLine("Tidspunkt: " + booking.Tidspunkt.Hour + ":" + booking.Tidspunkt.Minute);
                                sw.WriteLine("Læge: " + booking.AnsatDb.Fornavn + " " + booking.AnsatDb.Efternavn);
                                sw.WriteLine("Lokale: " + booking.BehandlingsrumDb.RumNavn);
                                sw.WriteLine("Patient: " + booking.PatientDb.Fornavn + " " + booking.PatientDb.Efternavn);
                                sw.WriteLine("Anslået tid: " + totalAnslåetTid + " Min");
                                sw.WriteLine("Behandling(er): " + behandlingString);
                                sw.WriteLine("");
                                sw.WriteLine("");
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                        finally
                        {
                            sw.Close();
                            var færdigBox = MessageBox.Show("Filen er gemt som tekstfil! Vil du åbne den?",
                                    "Success!",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                            if (færdigBox == DialogResult.Yes)
                            {
                                ÅbneGemtFil(sfd);
                            }
                        }
                }
            }
            //MessageBox.Show(Path.GetDirectoryName(sfd.FileName));
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
            try
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
                var lokale =
                    Db.BehandlingsrumDbs.FirstOrDefault(b => b.RumNavn == bookingOpretRedigere.comboBoxLokale.Text);

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

                MessageBox.Show("Booking oprettet", // Oprettelse besked
                    "Oprettet",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Form.ActiveForm.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl", // Oprettelse besked
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void GemBookingAkut(int patientID, AkutPatient akutPatient)
        {
            try
            {
                var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientID);
                var akutTider = AkutTider();
                var akutTidIndex = akutPatient.comboBoxTidspunkt.SelectedIndex;

                var createdBooking = new BookingDb
                {
                    PatientId = patient.PatientId,
                    Akut = true
                };
                createdBooking.Tidspunkt = akutTider[akutTidIndex];

                Db.BookingDbs.Add(createdBooking);
                LogSqlQuery();
                Db.SaveChanges();

                MessageBox.Show("Booking oprettet", // Oprettelse besked
                    "Oprettet",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Form.ActiveForm.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl", // Oprettelse besked
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void SletBooking(int bookingID)
        {
            var booking = Db.BookingDbs.FirstOrDefault(b => b.BookingId == bookingID);
            var bookinglinjer = Db.BehandlingslinjerDbs.Where(b => b.BookingDb.BookingId == booking.BookingId).ToList();

            foreach (var linjer in bookinglinjer)
            {
                Db.BehandlingslinjerDbs.Remove(linjer);
            }
            Db.BookingDbs.Remove(booking);
            Db.SaveChanges();
        }

        public List<DateTime> AkutTider()
        {
            var akutTidNu = DateTime.Now;
            TimeSpan morgenTid = new TimeSpan(8, 00, 0);
            TimeSpan lukkeTid = new TimeSpan(16, 30, 0);
            var akutTidMorgen = DateTime.Now.ToShortDateString() + " " + morgenTid;
            var akutTidLuk = DateTime.Now.ToShortDateString() + " " + lukkeTid;
            List<DateTime> akutTider = new List<DateTime>();
            akutTider.Add(akutTidNu);
            akutTider.Add(Convert.ToDateTime(akutTidMorgen));
            akutTider.Add(Convert.ToDateTime(akutTidLuk));

            return akutTider;
        }
    }
}