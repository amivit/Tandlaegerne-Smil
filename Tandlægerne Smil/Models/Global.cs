using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        public void LogSqlQuery()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("SQL QUERY KØRES: ");
            Console.ResetColor();
            Db.Database.Log = Console.Write;
        }
    }
}