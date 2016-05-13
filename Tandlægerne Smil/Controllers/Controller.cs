using System;
using Tandlægerne_Smil.Models;
using Tandlægerne_Smil.Views;

namespace Tandlægerne_Smil.Controllers
{
    internal class Controller
    {
        public Patient Patient = new Patient();
        public Faktura Faktura = new Faktura();
        public Book Book = new Book();
        public Venteværelse Venteværelse = new Venteværelse();


        public void StartGui()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Denne konsol er blot til debugging og slås fra for produktion.\n");
            Console.ResetColor();

            new StartGui();
        }
    }
}