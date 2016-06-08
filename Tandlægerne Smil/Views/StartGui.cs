using System.Windows.Forms;

namespace Tandlægerne_Smil.Views
{
    internal class StartGui
	{ //****KODET AF: PAUL****
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