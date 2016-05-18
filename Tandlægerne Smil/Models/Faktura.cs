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

        public void HentOplysningerPåValgteFakatura(int fakturaNR, ListView FakuraDetaljer)
        {
            FakuraDetaljer.Items.Clear();
            var faktura_Linjer_ = Db.FakturalinjerDbs.ToList();
            var behandlinger_ = Db.BehandlingDbs.ToList();

            var joined = from fl in faktura_Linjer_
                         join bl in behandlinger_
                         on fl.BehandlingId equals bl.BehandlingId
                         select new
                         {
                             fl.BehandlingId,
                             fl.FakturaId,
                             navn = bl.Navn,
                             bl.Pris
                         };


            var sortQurry = (from r in joined
                         where (r.FakturaId == fakturaNR)
                         select r).ToList();

             
            foreach (var r in sortQurry)
            {
                ListViewItem list = new ListViewItem(r.BehandlingId.ToString());
                list.SubItems.Add(r.FakturaId.ToString());
                list.SubItems.Add(r.navn);
                list.SubItems.Add(r.Pris.ToString());
                FakuraDetaljer.Items.Add(list);

            }
        }
	}
}