using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Pojazd_Magazynowy
    {
        private static int _licznik_pojazdow = 0;
        private readonly string _numer_rejestracyjny;
        public string Numer_Rejestracyjny { get { return _numer_rejestracyjny; } }
        public double Maksymalny_Udzwig_Kg { get; set; }
        public bool Czy_Sprawny { get; set; }

        public Pojazd_Magazynowy(string numer_rejestracyjny,double maksymalny_udzwig_kg,bool czy_sprawny)
        {
            _numer_rejestracyjny = numer_rejestracyjny;
            Maksymalny_Udzwig_Kg = maksymalny_udzwig_kg;
            Czy_Sprawny = czy_sprawny;
            _licznik_pojazdow++;
        }
        public Pojazd_Magazynowy(string numer_rejestracyjny, double maksymalny_udzwig_kg) : this(numer_rejestracyjny,maksymalny_udzwig_kg,true)

        {
        
        }
        public Pojazd_Magazynowy() : this("BRAK", 500.00)
        {

        }
        public static int Pobierz_Liczbe_Pojazdow()
        {
            return _licznik_pojazdow;
        }
    }
}
