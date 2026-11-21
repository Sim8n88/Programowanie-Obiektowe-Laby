using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
   class Pracownik_Etatowy:Pracownik
    {
        public uint Liczba_Godzin_Pracy_W_Miesiacu { get; set; }
        public decimal Stawka_Godzinowa { get; set; }
        public decimal Premia { get; set; }
        public override decimal  Oblicz_Wynagrodzenie()
        {
            return Stawka_Godzinowa * Liczba_Godzin_Pracy_W_Miesiacu + Premia;
        }

    }
}
