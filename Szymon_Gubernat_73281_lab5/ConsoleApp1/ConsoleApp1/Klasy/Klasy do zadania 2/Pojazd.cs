using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy.Klasy_do_zadania_2
{
    abstract class Pojazd
    {
        public string Marka { get; protected set; }
        public uint Rok_Produkcji { get; protected set; }
        protected Pojazd(string marka,uint rok_produkcji)
        {
            Marka = marka;
            Rok_Produkcji = rok_produkcji;
        }
        public abstract void Wyswietl_Informacje();
       

    }
}
