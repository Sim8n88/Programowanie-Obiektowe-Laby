using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{

    class Wyswietlacz_Tekstu
    {
        private static int Licznik_Wyswietlen = 0;
        public void Wyswietl(string x)
        {
            Console.WriteLine(x);
            Licznik_Wyswietlen++;

        }
        public void Wyswietl(int x)
        {
            Console.WriteLine(x);
            Licznik_Wyswietlen++;

        }
        public void Wyswietl(decimal x)
        {
            Console.WriteLine($"{x} zł");
            Licznik_Wyswietlen++;

        }

        public static void Wyswietl_Licznik()
        {
            Console.WriteLine($"Liczba wyświetleń: {Licznik_Wyswietlen}");
        }

    }
}
