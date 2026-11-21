using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Samochod_Osobowy:Pojazd
    {
        public int Liczba_Drzwi { get; set; }
        public double Pojemnosc_Silnika { get; set; }

        public Samochod_Osobowy(string marka, uint rok_produkcji, int  numer_seryjny, int liczba_drzwi,double pojemnosc_silnika) : base (marka, rok_produkcji)
        {
            Liczba_Drzwi = liczba_drzwi;
            Pojemnosc_Silnika = pojemnosc_silnika;
            Numer_Seryjny = numer_seryjny;
        }
        public void Wyswietl_Informacje_Samochodu()
        {
            Console.WriteLine($"Marka: {Marka} Rok produkcji: {Rok_Produkcji} Numer seryjny: {Numer_Seryjny} Liczba drzwi: {Liczba_Drzwi} Pojemność Silnika {Pojemnosc_Silnika}");
        }

    }
}
