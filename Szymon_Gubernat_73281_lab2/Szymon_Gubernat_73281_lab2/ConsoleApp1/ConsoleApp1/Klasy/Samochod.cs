using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rok_Produkcji { get; set; }

        public Typ_Paliwa Paliwo { get; set; }

        public Samochod()
        {
            Marka = "Opel";
            Model = "Astra";
            Rok_Produkcji = 2005;
            Paliwo = Typ_Paliwa.Benzyna;
        }
        public Samochod(string marka,string model,int rok_produkcji,Typ_Paliwa paliwo)
        {
            Marka = marka;
            Model = model;
            Rok_Produkcji = rok_produkcji;
            Paliwo = paliwo;
        }

        public Samochod(string marka,string model,int rok_produkcji,string paliwo)
        {
            Marka = marka;
            Model = model;
            Rok_Produkcji = rok_produkcji;
            paliwo = paliwo.ToLower();
            if (paliwo == "benzyna")
            {
                Paliwo = Typ_Paliwa.Benzyna;
            }
            else if (paliwo == "lpg")
            {
                Paliwo = Typ_Paliwa.LPG;
            }
            else if (paliwo == "elektryczny")
            {
                Paliwo = Typ_Paliwa.Elektryczny;
            }
            else
            {
                throw new Exception($"Niepoprawny typ paliwa {paliwo} ");
            }
        }
        public void Wyswietl_Informacje()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Rok Produkcji: {Rok_Produkcji}");
            Console.WriteLine($"Typ paliwa: {Paliwo}");
        }
    }
}
