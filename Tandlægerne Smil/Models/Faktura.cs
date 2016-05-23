using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tandlægerne_Smil.Controllers.DbController;
using System.Windows.Forms;
using Tandlægerne_Smil.Views;
using System.IO;

namespace Tandlægerne_Smil.Models
{
	internal class Faktura : Global
	{
		private readonly FakturaDb _fakturaDb = new FakturaDb();
		private readonly BehandlingslinjerDb _fakturalinjerDb = new BehandlingslinjerDb();
		private readonly PatientDb _patientDb = new PatientDb();
		private readonly BehandlingDb _behandlingDb = new BehandlingDb();
		private readonly AnsatDb _ansatDb = new AnsatDb();
		private StartForm startform;

		public Faktura(StartForm startform)
		{
			this.startform = startform;

		}

		public Faktura()
		{
			
		}

		public void UdskrivFaktura(int fakturaNR, int patientnr, string indnavn)
		{



			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			sfd.FileName = (indnavn +" Nr " + fakturaNR +" Dato " + DateTime.Today.ToShortDateString()).Replace(' ','_');
			//Taget fra http://stackoverflow.com/questions/14449407/writing-a-text-file-using-c-sharp
			sfd.FilterIndex = 1;
			StreamWriter SW = null;
			using (var db = new smildb())
			{
				
				var patient = db.PatientDbs.ToList();
				var bookning = db.BookingDbs.ToList();
				var læge = db.AnsatDbs.ToList();
				var behandling = db.BehandlingDbs.ToList();
				var fakturalinjer = db.BehandlingslinjerDbs.ToList();
				var faktura = db.FakturaDbs.ToList();

				
				var OrderLinier = from fl in fakturalinjer
							join bh in behandling
							on fl.BehandlingId equals bh.BehandlingId
						   select new
						   {
							  behandlingsNavn = bh.Navn,
							  behandlingsPris = bh.Pris,
							  fakturaID = fl.FakturaId 
						   };
				
				var OrderLinjerSortQurry = (from r in OrderLinier
								 where (r.fakturaID == fakturaNR)
								 select r).ToList();

				var patientSortQurry = (from r in patient
					where (r.PatientId == patientnr)
					select r).ToList();

				int PadVærdi = 60;
				string linje ="\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500";
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					using (SW = new StreamWriter(sfd.FileName))
						try
						{
								SW.WriteLine("Tandlægerne Smil A/S".PadLeft(PadVærdi+15));
								SW.WriteLine("TandlægeVej 420".PadLeft(PadVærdi + 15));
								SW.WriteLine("7100 Vejle".PadLeft(PadVærdi + 15));
								SW.WriteLine(Environment.NewLine);
								SW.WriteLine("Tlf: 420-1227".PadLeft(PadVærdi + 15));
								SW.WriteLine(Environment.NewLine);
								SW.WriteLine(Environment.NewLine);
								SW.WriteLine("Navn:".PadRight(15) + patientSortQurry[0].Fornavn +" "+patientSortQurry[0].Efternavn + "EasyBill Bank".PadLeft(PadVærdi - (1 + patientSortQurry[0].Fornavn.Length + patientSortQurry[0].Efternavn.Length)));
								SW.WriteLine("Cpr:".PadRight(15) + patientSortQurry[0].Cpr + "RegNr: 0042".PadLeft(PadVærdi - (patientSortQurry[0].Cpr.Length)));
								SW.WriteLine("Adresse:".PadRight(15) + patientSortQurry[0].Adresse + "KontoNr: 00024960125".PadLeft(PadVærdi - (patientSortQurry[0].Adresse.Length)));
								SW.WriteLine("PostNr:".PadRight(15) + patientSortQurry[0].Postnummer);
								SW.WriteLine("PatientNr:".PadRight(15)+patientSortQurry[0].PatientId);
								SW.WriteLine(Environment.NewLine);
								SW.WriteLine(Environment.NewLine);
								SW.WriteLine();
								SW.WriteLine();
								SW.WriteLine();

								SW.WriteLine("Behandling:".PadRight(PadVærdi)+"Pris:");
								SW.WriteLine(linje + linje + linje + linje );

							int testpris = 0;
							foreach (var r in OrderLinjerSortQurry)
							{
								SW.WriteLine(r.behandlingsNavn.PadRight(PadVærdi) + r.behandlingsPris+" DKK");
								try
								{
									string pris = r.behandlingsPris.ToString();
									testpris += int.Parse(pris);
								}
								catch(Exception)
								{ }
							}

								SW.WriteLine(linje + linje + linje + linje );
								SW.WriteLine("Total Pris:".PadRight(PadVærdi)+testpris+" DKK");
								
						}
						catch (Exception e)
						{
						  
							MessageBox.Show(e.ToString());
						}
						finally
						{
							
							SW.Close();
						}



				}
			}
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