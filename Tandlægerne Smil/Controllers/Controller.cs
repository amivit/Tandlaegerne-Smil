using System;
using Tandlægerne_Smil.Models;
using Tandlægerne_Smil.Views;

namespace Tandlægerne_Smil.Controllers
{
    internal class Controller
    {
        // Denne klasse er controlleren, hvor model-klasserne dannes som fields så der kan kigges på
        // Danner forbindelse mellem vores controller og models
        // Som fields, så viewet kan se vores
        public Patient Patient = new Patient();

        public Global Global = new Global();
        public Faktura Faktura = new Faktura();
        public Book Book = new Book();
        public Venteværelse Venteværelse = new Venteværelse();

        // Starter mainform
        public void StartGui()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Denne konsol er blot til debugging og slås fra for produktion.\n(kan også deaktiveres i menuen)");
            Console.ResetColor();

            new StartGui();
        }
    }
}