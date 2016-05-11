using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tandlægerne_Smil.Controllers.DbController;

namespace Tandlægerne_Smil.Models
{
    internal class Ansat : Global
    {
        private readonly AnsatDb _ansatDb = new AnsatDb();

        public void OpretAnsat()
        {
            throw new System.NotImplementedException();
        }

        public void DeaktivereAnsat()
        {
            throw new System.NotImplementedException();
        }

        public void GenaktivereAnsat()
        {
            throw new System.NotImplementedException();
        }
    }
}