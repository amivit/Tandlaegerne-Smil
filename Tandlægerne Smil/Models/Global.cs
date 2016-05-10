using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Global
    {
        // Alle Models nedavres fra denne "base-class".
        // Her kan tilføjes fields/metoder som alle sub-klasser skal kunne bruge
        // F.eks. skal alle have adgang til database-interfacet
        public Ismildb db;

        public Global()
        {
        }
    }
}