using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Patient : Global
    {
        
        public void OpretPatient(TextBox textBoxNavn, TextBox textBoxEfternavn, TextBox textBoxCPR, TextBox textBoxAdresse, TextBox textBoxPostnummer, TextBox textBoxTelefon) // Opret test patient her, denne metode bør slettes
        {
            try
            {
                var patient = new PatientDb // Smider data fra textboxende ind i de rigtige attributter
                {
                    Fornavn = textBoxNavn.Text,
                    Efternavn = textBoxEfternavn.Text,
                    Cpr = textBoxCPR.Text,
                    Adresse = textBoxAdresse.Text,
                    Postnummer = Convert.ToInt16(textBoxPostnummer.Text),
                    Telefon = textBoxTelefon.Text
                };
                bool postNummerCheck = Db.PostnummerDbs.Any(p => p.Postnr == patient.Postnummer); //Tjekker om postnummert er i posttabellen

                if (!postNummerCheck) // Hvis postnummert ikke findes
                {
                    MessageBox.Show("Postnummeret eksitere ikke",
                     "Fejl",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
                else // Hvis postnummert findes
                {               
                        Db.PatientDbs.Add(patient); // Tilføj patienten til tabellen
                        LogSqlQuery(); // Udskriv sql-query til konsol
                        Db.SaveChanges(); // Gem ændringerne i db
                   
                        MessageBox.Show("Patient oprettet", // Oprettelse besked
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

        public void SletPatient(int patientID)
        {
            var employer = new PatientDb { PatientId = patientID  };
            Db.PatientDbs.Attach(employer);
            Db.PatientDbs.Remove(employer);
            Db.SaveChanges();
        }

        public void RefreshPatientView(ListView listViewPatient)
        {
            var patientList = Db.PatientDbs.ToList();
            var index = 0;
            foreach (var patientDb in patientList)
            {
                ListViewItem lvi = new ListViewItem(patientList[index].Fornavn.Replace(" ", string.Empty));
                lvi.SubItems.Add(patientList[index].Efternavn.Replace(" ", string.Empty));
                lvi.SubItems.Add(patientList[index].Telefon);
                lvi.SubItems.Add(patientList[index].PatientId.ToString());
                listViewPatient.Items.Add(lvi);
                listViewPatient.Items[index].Group = listViewPatient.Groups[0];
                index++;
            }
        }
    }
}