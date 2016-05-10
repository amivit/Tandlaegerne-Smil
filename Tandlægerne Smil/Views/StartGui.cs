using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tandlægerne_Smil.Views
{
    internal class StartGui
    {
        public StartGui()
        {
            // Denne klasses eneste formål er at starte brugerfladen, således at det
            // ansvar ikke ligger hos controlleren, men her i viewet.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}