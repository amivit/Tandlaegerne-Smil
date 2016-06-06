using System;
using System.Diagnostics;
using System.Windows.Forms;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Global
    {
        // Alle Models nedavres fra denne "base-class".
        // Her kan tilføjes fields/metoder som alle sub-klasser skal kunne bruge
        // F.eks. skal alle have adgang til database-interfacet
        public smildb Db = new smildb();

        public void UdskrivSqlTilKonsol()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("SQL QUERY KØRES: ");
            Console.ResetColor();
            Db.Database.Log = Console.Write;
        }

        public static void ÅbneGemtFil(SaveFileDialog sfd)
        {
            // Denne metode kan bruges til at åbne et givet gemt fil fra SaveFileDialog
            // F.eks udprint af faktura eller dagens program
            string filSti = sfd.FileName;
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = filSti
            };
            process.Start();
            process.WaitForExit();
        }
    }
}