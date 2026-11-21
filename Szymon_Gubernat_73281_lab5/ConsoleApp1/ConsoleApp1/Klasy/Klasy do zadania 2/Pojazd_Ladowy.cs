using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy.Klasy_do_zadania_2
{
    abstract class Pojazd_Ladowy:Pojazd
    {
        protected Pojazd_Ladowy(string marka,uint rok_produkcji) : base(marka, rok_produkcji)
        {

        }
        public abstract decimal Oblicz_Zasieg();
        public abstract void Uruchom_Silnik();
    }
}
