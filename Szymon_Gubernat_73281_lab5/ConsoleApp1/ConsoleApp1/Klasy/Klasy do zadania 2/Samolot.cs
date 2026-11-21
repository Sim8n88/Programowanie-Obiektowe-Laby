using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy.Klasy_do_zadania_2
{
    class Samolot:Pojazd_Powietrzny,I_Tankowalny
    {
        public uint Liczba_Silnikow
        {
            get;set;
        }
        public decimal Pulap_Lotu { get; set; }
        public Samolot(string marka,uint rok_produkcji,uint liczba_silnikow,decimal pulap_lotu):base(marka,rok_produkcji)
        {
            Liczba_Silnikow = liczba_silnikow;
            Pulap_Lotu = pulap_lotu;
        }
        public override decimal Maksymalny_Pulap()
        {
            return Pulap_Lotu;
        }
        public override void Wyswietl_Informacje()
        {
            Console.WriteLine($"Marka: {Marka} Rok produkcji: {Rok_Produkcji} Liczba silników: {Liczba_Silnikow} Pułap lotu: {Pulap_Lotu}");
        }
        public void Zatankuj(decimal ilosc_litrow)
        {
            Console.WriteLine($"Zatankowano {ilosc_litrow} litrów paliwa ");
        }
    }
}
