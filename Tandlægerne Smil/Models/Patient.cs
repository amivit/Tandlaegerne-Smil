using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Patient : Global
    {
        public Patient()
        {
        }

        public void OpretTestPatient()
        {
            // Opret test patient her
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

            db.PatientDbs.Add(testPatient); // Tilføje testPatient til tabellen
            db.SaveChangesAsync(); // Gem ændringerne i db (async gør det i separat tråd i baggrunden)
            MessageBox.Show(@"TEST PATIENT OPRETTES");
        }
    }
}