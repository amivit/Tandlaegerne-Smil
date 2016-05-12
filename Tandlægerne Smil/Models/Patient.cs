using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Patient : Global
    {
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
            Db.Database.Log = Console.WriteLine; // Udskriv sql-query til konsol
            Db.SaveChangesAsync(); // Gem ændringerne i db (async gør det i baggrunden vha. en separat tråd)
            MessageBox.Show(@"TEST PATIENT OPRETTES");
        }

        public void RefreshPatientView(ListView listViewPatient)
        {
            var patientList = Db.PatientDbs.ToList();
            var index = 0;
            foreach (var patientDb in patientList)
            {
                ListViewItem lvi = new ListViewItem(patientList[index].Fornavn.Replace(" ", string.Empty));
                lvi.SubItems.Add(patientList[index].Efternavn.Replace(" ", string.Empty));
                lvi.SubItems.Add(patientList[index].Telefon.ToString().Replace(" ", string.Empty));
                listViewPatient.Items.Add(lvi);
                listViewPatient.Items[index].Group = listViewPatient.Groups[0];
                index++;
            }
        }
    }
}