using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tandlægerne_Smil.Controllers.DbController;
using System.Windows.Forms;


namespace Tandlægerne_Smil.Models
{
    internal class Faktura : Global
    {
        private readonly FakturaDb _fakturaDb = new FakturaDb();
        private readonly FakturalinjerDb _fakturalinjerDb = new FakturalinjerDb();
        private readonly PatientDb _patientDb = new PatientDb();
        private readonly BehandlingDb _behandlingDb = new BehandlingDb();
        private readonly AnsatDb _ansatDb = new AnsatDb();

        

        public void UdskrivFaktura()
        {
               
        }

        public void BetalingModtaget()
        {
            throw new System.NotImplementedException();
        }

        public void hentFaktura(int patientID, ListView V)
        {
            var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientID);

            var query = (from r in Db.FakturaDbs.AsEnumerable()
                         where (r.PatientId == patientID)
                         select r).ToList();


            
            var index = 0;
            foreach (var patientDb in query)
            {
                ListViewItem lvi = new ListViewItem(query[index].FakturaId.ToString());
                lvi.SubItems.Add(patient.Fornavn.Replace(" ", string.Empty) + " " + patient.Efternavn.Replace(" ", string.Empty)).ToString();
                lvi.SubItems.Add(patientID.ToString());
                lvi.SubItems.Add(query[index].FakturaDato.ToString());

                V.Items.Add(lvi);
               // V.Items[index].Group = V.listViewPatient.Groups[0];
                index++;
            }
        }
    }
}