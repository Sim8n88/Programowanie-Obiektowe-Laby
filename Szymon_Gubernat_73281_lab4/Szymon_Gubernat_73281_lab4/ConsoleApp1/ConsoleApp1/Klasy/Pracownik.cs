using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public virtual decimal Oblicz_Wynagrodzenie()
        {
            return 5000M;
        }

    }
}
