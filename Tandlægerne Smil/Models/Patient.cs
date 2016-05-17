﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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
            var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientID);
            Db.PatientDbs.Remove(patient);
            Db.SaveChanges();
            Form.ActiveForm.Close();
        }

        public void LoadRedigerePatient(int patientID, PatientRedigere patientRedigere)
        {
            var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientID);
            patientRedigere.textBoxNavn.Text = patient.Fornavn;
            patientRedigere.textBoxAdresse.Text = patient.Adresse;
            patientRedigere.textBoxCPR.Text = patient.Cpr;
            patientRedigere.textBoxEfternavn.Text = patient.Efternavn;
            patientRedigere.textBoxID.Text = patient.PatientId.ToString();
            patientRedigere.textBoxPostnummer.Text= patient.Postnummer.ToString();
            patientRedigere.textBoxTelefon.Text = patient.Telefon;

        }

        public void RefreshPatientView(ListView listViewPatient)
        {
            
            var patientList = Db.PatientDbs.ToList();
            var index = 0;
            // Db.Entry(Db.PatientDbs).Reload();
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

        public void RedigerePatientGem(int patientID, PatientRedigere patientRedigere)
        {
            try
            {
                {
                    
                    var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientID); // Denne LINQ i stedet for nedenstående
                    Db.PatientDbs.Attach(patient);
                    patient.Fornavn = patientRedigere.textBoxNavn.Text;
                    patient.Adresse = patientRedigere.textBoxAdresse.Text;
                    patient.Cpr = patientRedigere.textBoxCPR.Text;
                    patient.Efternavn = patientRedigere.textBoxEfternavn.Text;
                    patientRedigere.textBoxID.Text = patient.PatientId.ToString();
                    patientRedigere.textBoxPostnummer.Text = patient.Postnummer.ToString();
                    patient.Telefon = patientRedigere.textBoxTelefon.Text;
                    


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
                        //Db.PatientDbs.Add(patient); // Tilføj patienten til tabellen
                        LogSqlQuery(); // Udskriv sql-query til konsol
                        Db.SaveChanges(); // Gem ændringerne i db

                        MessageBox.Show("Patient oprettet", // Oprettelse besked
                            "Oprettet",
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