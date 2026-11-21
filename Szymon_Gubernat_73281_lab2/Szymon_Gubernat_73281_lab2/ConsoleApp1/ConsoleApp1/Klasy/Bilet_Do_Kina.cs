using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Bilet_Do_Kina
    {
        public static int Licznik_Sprzedanych_Biletow=0;
        public string Nazwa_Filmu { get; set; }
        public int Rzad { get; set; }
        public int Miejsce { get; set; }
        public decimal Cena { get; set; }

        public Bilet_Do_Kina()
        {
            Nazwa_Filmu = "Shrek 2";
            Rzad = 2;
            Miejsce = 3;
            Cena = 20.99M;
            Licznik_Sprzedanych_Biletow++;
        }
        public Bilet_Do_Kina(string nazwa_filmu,int rzad,int miejsce,decimal cena)
        {
            Nazwa_Filmu = nazwa_filmu;
            Rzad = rzad;
            Miejsce = miejsce;
            Cena = cena;
            Licznik_Sprzedanych_Biletow++;
        }

        public static void Podsumowanie_Sprzedazy()
        {
            Console.WriteLine($"Liczba sprzedanych biletów: {Licznik_Sprzedanych_Biletow}");
        }
    }
}
