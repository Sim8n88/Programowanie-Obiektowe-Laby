using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy.Klasy_do_zadania_2
{
   class Samochod:Pojazd_Ladowy,I_Tankowalny
    {
        public decimal Pojemnosc_Zbiornika { get; set; }
        public decimal Srednie_Spalanie { get; set; }
        public Samochod(string marka,uint rok_produkcji,decimal pojemnosc_zbiornika,decimal srednie_spalanie):base(marka,rok_produkcji)
        {
            Pojemnosc_Zbiornika = pojemnosc_zbiornika;
            Srednie_Spalanie = srednie_spalanie;
        }
       public override decimal Oblicz_Zasieg() {
            return Pojemnosc_Zbiornika / Srednie_Spalanie* 100;
        }
        public override void Uruchom_Silnik()
        {
            Console.WriteLine($"Silnik {Marka} został uruchomiony");
        }
        public override void Wyswietl_Informacje()
        {
            Console.WriteLine($"Marka: {Marka}, Rok produkcji: {Rok_Produkcji}, Pojemność zbiornika: {Pojemnosc_Zbiornika}, Średnie spalanie: {Srednie_Spalanie}");
        }
        public void Zatankuj(decimal ilosc_litrow)
        {
            Console.WriteLine($"Zatankowano: {ilosc_litrow} paliwa");
        }

    }
}
