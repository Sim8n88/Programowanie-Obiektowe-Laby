using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleApp1.Klasy
{
    public class Rejestr_Ocen
    {
        private List<double> _oceny;
        public Rejestr_Ocen()
        {
            _oceny = new List<double>();
        }
        public void Dodaj_Ocene(double ocena)
        {
            if (ocena >= 2.0 && ocena <= 5.0)
            {
                _oceny.Add(ocena);
            }
        }
        public int Liczba_Ocen()
        {
            return _oceny.Count;
        }
        public double Oblicz_Srednia()
        {
            double suma = 0;
            if (_oceny.Count == 0)
            {
                return 0.0;
            }
            else
            {
                foreach(double ocena in _oceny)
                {
                    suma += ocena;
                }
            }
            return suma / _oceny.Count;
        }
        public double Najwyzsza_Ocena()
        {
            if (_oceny.Count == 0)
            {
                return 0.0;
            }
            else
            {
                return _oceny.Max();
            }
           
        }
        public double Najnizsza_Ocena()
        {
            if (_oceny.Count == 0)
            {
                return 0.0;
            }
            else
            {
                return _oceny.Min();
            }
            
        }
        public void Posortuj_Oceny()
        {
            _oceny.Sort();
        }
        public void Wyswietl_Wszystkie()
        {
            foreach(double ocena in _oceny)
            {
                Console.WriteLine(ocena);
            }
        }
    }
}
