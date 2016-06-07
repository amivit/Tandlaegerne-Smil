using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Views;

namespace Tandlægerne_Smil.Models
{
    internal class Book : Global
    {
        public void GemDagensProgram(StartForm _startForm)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            var dato = _startForm.dateTimePicker.Value;
            sfd.FileName = ("Dagens-Program_" + dato.Day + "-" + dato.Month + "-" + dato.Year);
            // Taget fra http://stackoverflow.com/questions/14449407/writing-a-text-file-using-c-sharp
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
                                    db.BehandlingDbs.Where(b => b.BehandlingslinjerDbs.Any(BB => BB.BookingId == booking.BookingId))
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
                                if (booking.AnsatDb != null)
                                    sw.WriteLine("Læge: " + booking.AnsatDb.Fornavn + " " + booking.AnsatDb.Efternavn);
                                if (booking.BehandlingsrumDb != null)
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
                //Gemmer den valgte patients Fields i en liste
                var CreatedBooking = new BookingDb();
                //Opretter en ny booking
                // Match Læge fra combobox, med databasen. Fornavn og efternavn skal splittes, da de ligger i 2 forskellige kolonner i db'en
                var names = bookingOpretRedigere.comboBoxLæge.Text.Split(' ');
                string lægeFornavn = names[0];
                string lægeEfternavn = names[1];
                var læge = Db.AnsatDbs.FirstOrDefault(a => a.Fornavn == lægeFornavn && a.Efternavn == lægeEfternavn);
                CreatedBooking.AnsatDb = læge;
                //Visuelt er lægens fornavn og efternavn sat sammen i selve formen for at give et bedre overblik for brugeren
                //der for er det vigtigt at vi splitter navnet op så vi kan knytte bookingen til valgte læge

                // Match Lokale fra combobox, med lokale i databasen
                var lokale =
                Db.BehandlingsrumDbs.FirstOrDefault(b => b.RumNavn == bookingOpretRedigere.comboBoxLokale.Text);

                var date = bookingOpretRedigere.datePicker.Value; //valgte dato ud fra vores date picker
                var time = bookingOpretRedigere.dateTimeOnlyPicker.Value; // valgte tidspunkt ud fra vores picker

                CreatedBooking.Tidspunkt = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, 0);
                //gemmer tidspunktet til databasen

                CreatedBooking.PatientId = patient.PatientId; // knytter patient id til bookingen
                CreatedBooking.LokaleId = lokale.RumId; // lokalet knyttes

                var addedBooking = Db.BookingDbs.Add(CreatedBooking);
                UdskrivSqlTilKonsol(); // udskriver til vores konsol
                Db.SaveChanges(); // Opret bookingen inden vi tilføjer behandlinger til den

                for (int i = 0; i < bookingOpretRedigere.listViewBehandling.Items.Count; i++)
                {
                    var behandlingsNavn = bookingOpretRedigere.listViewBehandling.Items[i].Text;
                    var behandlingTemp = Db.BehandlingDbs.FirstOrDefault(b => b.Navn == behandlingsNavn);

                    var linje = new BehandlingslinjerDb
                    {
                        BookingId = addedBooking.BookingId,
                        BehandlingId = behandlingTemp.BehandlingId
                    };
                    //her oprettes linjerne til bookingen ud fra hvad brugeren har valgt at behandlinger
                    // de tilføjes så til databasen en ad gangen
                    Db.BehandlingslinjerDbs.Add(linje);
                }
                UdskrivSqlTilKonsol();
                Db.SaveChanges(); // gemmer alle informationerne i databasen

                MessageBox.Show("Booking oprettet", // Oprettelse besked udskrives
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
            // Denne metode opretter en akut-booking, der på teknisk plan
            // blot er en almindelig men tom booking, hvor akut-bool på true i databasen
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
                UdskrivSqlTilKonsol();
                Db.SaveChanges();

                MessageBox.Show("Akut Booking Oprettet", // Oprettelse besked
                    "Succes",
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
            // Denne metode tager imod et booking id, finder alle dens behandlingslinjer, og sletter det hele fra databasen
            var booking = Db.BookingDbs.FirstOrDefault(b => b.BookingId == bookingID);
            var bookinglinjer = Db.BehandlingslinjerDbs.Where(b => b.BookingDb.BookingId == booking.BookingId).ToList();

            foreach (var linjer in bookinglinjer)
            {
                Db.BehandlingslinjerDbs.Remove(linjer);
            }
            // booking.Akut = false; // Dette er ikke nødvendigt?
            // TODO: Slet ovenstående
            Db.BookingDbs.Remove(booking);
            Db.SaveChanges();
        }

        public List<DateTime> AkutTider()
        {
            // Denne metode opretter akut-tider til en liste, som senere hentes til viewet i en combobox
            // De tider bør ligge i databasen, så listen dannes derfra. Men for nu er de hardcoded ind i programmet
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