using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Pracownik_Godzinowy:Pracownik
    {
        public uint Liczba_Godzin_Pracy_W_Miesiacu { get; set; }
        public decimal Stawka_Godzinowa { get; set; }
        
        public override decimal Oblicz_Wynagrodzenie()
        {
            return Liczba_Godzin_Pracy_W_Miesiacu * Stawka_Godzinowa;
        }

    }
}
