using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
     class Kwadrat:Figura_2D
    {
        public decimal Dlugosc_Boku { get; set; }
        public Kwadrat(decimal dlugosc_boku):base("Kwadrat")
        {
            Dlugosc_Boku = dlugosc_boku;
        }
        public override decimal Pole()
        {
            return Dlugosc_Boku * Dlugosc_Boku;  
        }
        public override decimal Obwod()
        {
            return 4 * Dlugosc_Boku;
        }
        public override void Wyswietl_Informacje()
        {
            Console.WriteLine($"Długość boku {Nazwa} wynosi: {Dlugosc_Boku} Pole wynosi: {Pole()} a Obwód wynosi: {Obwod()}");
        }
    }
}
