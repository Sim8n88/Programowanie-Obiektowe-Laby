using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy.Klasy_do_zadania_2
{
   abstract class Pojazd_Powietrzny:Pojazd
    {
        protected Pojazd_Powietrzny(string marka,uint rok_produkcji) : base(marka, rok_produkcji)
        {

        }
        public abstract decimal Maksymalny_Pulap();
    }
}
