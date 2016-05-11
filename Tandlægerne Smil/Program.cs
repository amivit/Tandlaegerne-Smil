using System;
using Tandlægerne_Smil.Controllers;

namespace Tandlægerne_Smil
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Start controlleren og brugerfladen
            var controller = new Controller();
            controller.StartGui();
        }
    }
}