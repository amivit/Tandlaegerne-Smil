using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Patient : Global
    {
        private readonly PatientDb _patientDb = new PatientDb();

        public void OpretTestPatient() // Opret test patient her, denne metode bør slettes
        {
            var testPatient = new PatientDb // En måde at gøre det på
            {
                Adresse = "Testvej1234",
                Cpr = 1111909999,
                Efternavn = "Wittig",
                Fornavn = "Paul",
                Postnummer = 7100
            };

            testPatient.Fornavn = "test"; // En anden måde at gøre det på
            testPatient.Cpr = 1111959999;

            Db.PatientDbs.Add(testPatient); // Tilføje testPatient til tabellen
            Db.SaveChangesAsync(); // Gem ændringerne i db (async gør det i baggrunden vha. en separat tråd)
            MessageBox.Show(@"TEST PATIENT OPRETTES");
        }

        public void OpretPatient()
        {
            throw new System.NotImplementedException();
        }
    }
}