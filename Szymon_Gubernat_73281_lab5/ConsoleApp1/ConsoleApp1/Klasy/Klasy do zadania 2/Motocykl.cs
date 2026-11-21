using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy.Klasy_do_zadania_2
{
     class Motocykl:Pojazd_Ladowy,I_Elektryczny
    {
        public decimal Pojemnosc_Baterii { get; set; }
        public decimal Zuzycie_Energii { get; set; }
        public Motocykl(string marka,uint rok_produkcji,decimal pojemnosc_baterii,decimal zuzycie_energii) : base(marka, rok_produkcji)
        {
            Pojemnosc_Baterii = pojemnosc_baterii;
            Zuzycie_Energii = zuzycie_energii;
        }
        public override decimal Oblicz_Zasieg()
        {
            return Pojemnosc_Baterii / Zuzycie_Energii * 100;
        }
        public override void Uruchom_Silnik()
        {
            Console.WriteLine($"Silnik {Marka} został uruchomiony");
        }
        public override void Wyswietl_Informacje()
        {
            Console.WriteLine($"Marka: {Marka} Rok produkcji: {Rok_Produkcji} Pojemność baterii: {Pojemnosc_Baterii} Zużycie energii: {Zuzycie_Energii}");
        }
        public void Naladuj(decimal ilosc_energii)
        {
            Console.WriteLine($"{Marka} naładowano {ilosc_energii} kwH");
        }
    }
}
