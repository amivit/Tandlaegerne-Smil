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
            MessageBox.Show(@"TEST PATIENT OPRETTES");
            db.PatientDbs.Add(new PatientDb());
            db.SaveChangesAsync(); // Gem ændringer i db
        }
    }
}