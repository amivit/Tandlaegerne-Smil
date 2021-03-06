﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Faktura : Global
    {
        public void UdskrivFaktura(int fakturaNR, int patientnr, string indnavn)
        //Udskriver faktura med et genereret navn.
        { //****KODET AF: KASPER, NIKOLAJ & PATRICK****
            var dateToday = DateTime.Today;
            SaveFileDialog sfd = new SaveFileDialog
            // Taget fra http://stackoverflow.com/questions/14449407/writing-a-text-file-using-c-sharp
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FileName =
                    (indnavn + "_Nr_" + fakturaNR + "_Dato_" + dateToday.Day + "_" + dateToday.Month + "_" +
                     dateToday.Year),
                FilterIndex = 1
            };
            using (var db = new smildb())
            {
                var patient = db.PatientDbs.ToList(); //heenter patientoplysninger
                var behandling = db.BehandlingDbs.ToList(); //indeholder navn og pris
                var behandlingslinje = db.BehandlingslinjerDbs.ToList(); // tidliger faktura linjer
                var faktura = db.FakturaDbs.ToList();

                var OrderLinier = from fi in faktura
                                  join bl in behandlingslinje
                                      on fi.FakturaId equals bl.FakturaId
                                  join be in behandling
                                      on bl.BehandlingId equals be.BehandlingId
                                  select new
                                  {
                                      _behandlingsNavn = be.Navn,
                                      _behandlingsPris = be.Pris,
                                      _fakturaNummer = fi.FakturaId
                                  };

                var ordreLinjer = (from r in OrderLinier
                                   where r._fakturaNummer == fakturaNR
                                   select r).ToList();

                var patienter = (from r in patient
                                 where r.PatientId == patientnr
                                 select r).ToList();

                int padVærdi = 60;
                var linje = $"───────────────────";
                if (sfd.ShowDialog() == DialogResult.OK) //Tjekker for dialog resultat.
                {
                    StreamWriter SW = null;
                    using (SW = new StreamWriter(sfd.FileName)) //opretter ny faktura.
                        try
                        {
                            SW.WriteLine("Tandlægerne Smil A/S".PadLeft(padVærdi + 15));
                            SW.WriteLine("TandlægeVej 420".PadLeft(padVærdi + 15));
                            SW.WriteLine("7100 Vejle".PadLeft(padVærdi + 15));
                            SW.WriteLine(Environment.NewLine);
                            SW.WriteLine("Tlf: 420-1337".PadLeft(padVærdi + 15));
                            SW.WriteLine(Environment.NewLine);
                            SW.WriteLine(Environment.NewLine);
                            SW.WriteLine("Navn:".PadRight(15) + patienter[0].Fornavn + " " + patienter[0].Efternavn +
                            "EasyBill Bank".PadLeft(padVærdi - (1 + patienter[0].Fornavn.Length +
                            patienter[0].Efternavn.Length)));
                            SW.WriteLine("Cpr:".PadRight(15) + patienter[0].Cpr + "RegNr: 0042".PadLeft(padVærdi -
                            (patienter[0].Cpr.Length)));
                            SW.WriteLine("Adresse:".PadRight(15) + patienter[0].Adresse +
                            "KontoNr: 00024960125".PadLeft(padVærdi - (patienter[0].Adresse.Length)));
                            SW.WriteLine("PostNr:".PadRight(15) + patienter[0].Postnummer);
                            SW.WriteLine("PatientNr:".PadRight(15) + patienter[0].PatientId);
                            SW.WriteLine(Environment.NewLine);
                            SW.WriteLine(Environment.NewLine);
                            SW.WriteLine();
                            SW.WriteLine();
                            SW.WriteLine();

                            SW.WriteLine("Behandling:".PadRight(padVærdi) + "Pris: (incl moms)");
                            SW.WriteLine(linje + linje + linje + linje);

                            int testpris = 0;
                            double moms = 0;
                            foreach (var r in ordreLinjer) //indhenter ordrelinjer pr. behandling.
                            {
                                SW.WriteLine(r._behandlingsNavn.PadRight(padVærdi) + r._behandlingsPris + " DKK");
                                try
                                {
                                    var pris = r._behandlingsPris.ToString();
                                    testpris += int.Parse(pris);
                                    moms = testpris;
                                }
                                catch (Exception)
                                {
                                    // ignored
                                }
                            }

                            SW.WriteLine(linje + linje + linje + linje);
                            SW.WriteLine("Pris ekskl. Moms: ".PadRight(padVærdi) + (moms * 0.8) + " DKK");
                            SW.WriteLine("Moms udgør: ".PadRight(padVærdi) + (moms * 0.2) + " DKK");
                            SW.WriteLine(Environment.NewLine);
                            SW.WriteLine("Pris inkl. Moms: ".PadRight(padVærdi) + testpris + " DKK");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                        finally
                        {
                            SW.Close(); //Færdiggørelse af faktura.
                            var færdigBox = MessageBox.Show("Filen er gemt som tekstfil! Vil du åbne den?",
                                    "Success!",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                            if (færdigBox == DialogResult.Yes)
                            {
                                ÅbneGemtFil(sfd);
                            }
                        }
                }
            }
        }

        public void HentFaktura(int patientId, ListView V)
        { //****KODET AF: PATRICK & NIKOLAJ****
            var patient = Db.PatientDbs.FirstOrDefault(p => p.PatientId == patientId);

            var query = (from r in Db.FakturaDbs.AsEnumerable()
                         where (r.PatientId == patientId)
                         select r).ToList();

            foreach (var patientDb in query)
            {
                ListViewItem lvi = new ListViewItem(patientDb.FakturaId.ToString());
                lvi.SubItems.Add(patient.Fornavn.Replace(" ", string.Empty) + " " + patient.Efternavn.Replace(" ", string.Empty)).ToString();
                lvi.SubItems.Add(patientId.ToString());
                lvi.SubItems.Add(patientDb.FakturaDato.ToString());
                V.Items.Add(lvi);
            }
        }

        public void HentOplysningerPåValgteFakatura(int fakturaNr, ListView fakuraDetaljer)
        { //****KODET AF: PATRICK****
            fakuraDetaljer.Items.Clear();

            var behandlingslinjer = Db.BehandlingslinjerDbs.Where(b => b.FakturaId == fakturaNr).ToList();

            foreach (var item in behandlingslinjer)
            {
                ListViewItem listViewItem = new ListViewItem(item.BehandlingId.ToString());
                listViewItem.SubItems.Add(item.FakturaId.ToString());
                listViewItem.SubItems.Add(item.BehandlingDb.Navn);
                listViewItem.SubItems.Add(item.BehandlingDb.Pris.ToString());
                fakuraDetaljer.Items.Add(listViewItem);
            }
        }
    }
}