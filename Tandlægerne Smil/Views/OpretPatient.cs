using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Views
{
    public partial class OpretPatient : Form
    {
        public OpretPatient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var OpretPatient = new PatientDb // En måde at gøre det på
            {
                Fornavn = textBoxNavn.Text,
                Efternavn = textBoxEfternavn.Text,
                Cpr = Convert.ToInt32(textBoxCPR.Text),
                Adresse = textBoxAdresse.Text,    
                Postnummer = Convert.ToInt16(textBoxPostnummer.Text) ,
                Telefon = textBoxTelefon.Text;
            };

          

            Db.PatientDbs.Add(testPatient); // Tilføje testPatient til tabellen
            LogSqlQuery(); // Udskriv sql-query til konsol
            Db.SaveChangesAsync(); // Gem ændringerne i db (async gør det i baggrunden vha. en separat tråd)
            MessageBox.Show(@"TEST PATIENT OPRETTES");
        }
    }
}
