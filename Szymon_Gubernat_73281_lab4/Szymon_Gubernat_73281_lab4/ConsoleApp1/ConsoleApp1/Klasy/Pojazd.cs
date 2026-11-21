using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Pojazd
    {
        public string Marka { get; set; }
        public uint Rok_Produkcji { get; set; }
        public void Wyswietl_Podstawowe_Informacje() {
            Console.WriteLine($"Marka: {Marka} Rok produkcji: {Rok_Produkcji} Numer seryjny: {Numer_Seryjny}");
        }
        private int _numer_seryjny;
        public int Numer_Seryjny
        {
            get
            {
                return _numer_seryjny;
            }
            protected set { _numer_seryjny = value; }
        }
        public Pojazd(string marka,uint rok_produkcji)
        {
            Marka = marka;
            Rok_Produkcji = rok_produkcji;
        }
    }

}
