using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tandlægerne_Smil.Models;
using Tandlægerne_Smil.Views;

namespace Tandlægerne_Smil
{
    internal class Controller
    {
        public Patient patient = new Patient();
        public Faktura faktura = new Faktura();
        public Book book = new Book();
        public Venteværelse venteværelse = new Venteværelse();

        public Controller()
        {
            // Controller constructor her
        }

        public void StartGui()
        {
            new StartGui();
        }
    }
}