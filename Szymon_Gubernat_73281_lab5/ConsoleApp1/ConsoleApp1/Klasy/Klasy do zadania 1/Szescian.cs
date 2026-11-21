using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Szescian:Figura_3D
    {
        public decimal Dlugosc_Krawedzi { get; set; }
        public Szescian(decimal dlugosc_krawedzi) : base("Sześcian")
        {
            Dlugosc_Krawedzi = dlugosc_krawedzi;
        }
        public override decimal Objetosc()
        {
            return Dlugosc_Krawedzi * Dlugosc_Krawedzi * Dlugosc_Krawedzi;
        }
        public override decimal Pole_Powierzchni()
        {
            return 6 * Dlugosc_Krawedzi * Dlugosc_Krawedzi;
        }
        public override void Wyswietl_Informacje()
        {
            Console.WriteLine($"{Nazwa} ma krawędź o długości: {Dlugosc_Krawedzi} a jego Objetość wynosi: {Objetosc()} natomiast jego Pole powierzchni wynosi: {Pole_Powierzchni()}");
        }
    }
}
