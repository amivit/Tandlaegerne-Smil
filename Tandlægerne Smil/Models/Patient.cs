using System;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;
using Tandlægerne_Smil.Views;

namespace Tandlægerne_Smil.Models
{
    internal class Patient : Global
    {
        public void OpretPatient(TextBox textBoxNavn, TextBox textBoxEfternavn, TextBox textBoxCPR, TextBox textBoxAdresse, TextBox textBoxPostnummer, TextBox textBoxTelefon) // Opret test patient her, denne metode bør slettes
        {
            try
            {   // Her opretter vi et patient-objekt og pålægger passende data ind fra formen på objektets attributter
                var patient = new PatientDb
                {
                    Fornavn = textBoxNavn.Text,
                    Efternavn = textBoxEfternavn.Text,
                    Cpr = textBoxCPR.Text,
                    Adresse = textBoxAdresse.Text,
                    Postnummer = Convert.ToInt16(textBoxPostnummer.Text),
                    Telefon = textBoxTelefon.Text,
                    Tandlægeskræk = false
                };

                // Her tjekkes om det skrevede postnummer eksistere i databasens postnummer-tabel
                // Entity retunere false på .Any, hvis der ikke findes noget der matcher
                bool postNummerCheck = Db.PostnummerDbs.Any(p => p.Postnr == patient.Postnummer);

                if (!postNummerCheck) // Hvis postnummeret ikke findes
                {
                    MessageBox.Show("Postnummeret eksistere ikke - prøv igen",
                     "Oops",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                }
                else // Hvis postnummeret findes
                {
                    Db.PatientDbs.Add(patient); // Tilføj patienten til tabellen
                    Db.SaveChanges(); // Gem ændringerne i db
                    UdskrivSqlTilKonsol(); // Vores metode til at smide rå sql-query's ud til konsollen

                    MessageBox.Show("Patient oprettet",
                        "Oprettet",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Form.ActiveForm.Close();
                }
            }
            catch (Exception) // Fejl besked
            {
                MessageBox.Show("Fejl i input",
                    "Fejl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void SletPatient(int patientId)
        {
            try
            {
                var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientId);
                Db.PatientDbs.Remove(patient);
                Db.SaveChanges();
                Form.ActiveForm.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Patienten har stadig ubetalte faktura liggende\n" +
                    "Slet venneligst dem først før sletningen kan genneføres", "Fejl!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadRedigerePatient(int patientId, PatientRedigere patientRedigere)
        {
            var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientId);
            patientRedigere.textBoxNavn.Text = patient.Fornavn;
            patientRedigere.textBoxAdresse.Text = patient.Adresse;
            patientRedigere.textBoxCPR.Text = patient.Cpr;
            patientRedigere.textBoxEfternavn.Text = patient.Efternavn;
            patientRedigere.textBoxID.Text = patient.PatientId.ToString();
            patientRedigere.textBoxPostnummer.Text = patient.Postnummer.ToString();
            patientRedigere.textBoxTelefon.Text = patient.Telefon;
            patientRedigere.checkBoxTandlægeSkræk.Checked = patient.Tandlægeskræk.Value;
            patientRedigere.textBoxNoter.Text = patient.Noter;
        }

        public void RedigerePatientGem(int patientID, PatientRedigere patientRedigere)
        {
            try
            {
                {
                    var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientID);
                    Db.PatientDbs.Attach(patient);
                    patient.Fornavn = patientRedigere.textBoxNavn.Text;
                    patient.Adresse = patientRedigere.textBoxAdresse.Text;
                    patient.Cpr = patientRedigere.textBoxCPR.Text;
                    patient.Efternavn = patientRedigere.textBoxEfternavn.Text;
                    patientRedigere.textBoxID.Text = patient.PatientId.ToString();
                    patientRedigere.textBoxPostnummer.Text = patient.Postnummer.ToString();
                    patient.Telefon = patientRedigere.textBoxTelefon.Text;
                    patient.Tandlægeskræk = patientRedigere.checkBoxTandlægeSkræk.Checked;
                    patient.Noter = patientRedigere.textBoxNoter.Text;

                    bool postNummerCheck = Db.PostnummerDbs.Any(p => p.Postnr == patient.Postnummer); //Tjekker om postnummert er i posttabellen

                    if (!postNummerCheck) // Hvis postnummert ikke findes
                    {
                        MessageBox.Show("Postnummeret eksistere ikke",
                         "Fejl",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    }
                    else // Hvis postnummert findes
                    {
                        //Db.PatientDbs.Add(patient); // Tilføj patienten til tabellen
                        UdskrivSqlTilKonsol(); // Udskriv sql-query til konsol
                        Db.SaveChanges(); // Gem ændringerne i db
                        Db.Database.Connection.Close();

                        MessageBox.Show("Patient redigeret.", // Oprettelse besked
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Form.ActiveForm.Close();
                    }
                };
            }
            catch (Exception) // Fejl besked
            {
                MessageBox.Show("Fejl i input",
                    "Fejl",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}