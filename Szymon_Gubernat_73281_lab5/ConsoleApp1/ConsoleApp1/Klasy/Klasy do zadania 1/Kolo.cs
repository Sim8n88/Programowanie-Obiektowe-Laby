using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
     class Kolo:Figura_2D
    {
        public decimal Promien { get; set; }
        public Kolo(decimal promien) : base("Koło")
        {
            Promien = promien;
        }
        public override decimal Pole()
        {
            return 3.14M * (Promien *Promien);
        }
        public override decimal Obwod()
        {
            return 2 * 3.14M * Promien;
        }
        public override void Wyswietl_Informacje()
        {
            Console.WriteLine($"{Nazwa} ma promień {Promien} jego Pole wynosi: {Pole()} natomiast Obwód {Obwod()}");
        }
    }
}
