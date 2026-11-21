using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
     public class Kolekcja_Liczb
    {
        private List<int> _liczby;
        public Kolekcja_Liczb(int[] tab)
        {
            _liczby = new List<int>();
            _liczby.AddRange(tab);
        }
        public void Wyswietl_Liczby()
        {
            foreach (int liczba in _liczby)
            {
                Console.Write($"{liczba}, ");
  
            }
            Console.WriteLine();
        }

        public List<int>  Pobierz_Ujemne()
        {
            List<int> tab = new List<int>();
            foreach(int liczba in _liczby)
            {
                if (liczba < 0)
                {
                    tab.Add(liczba);
                }
            }
            return tab;
        }
        public void Usun_Ujemne()
        {
            for (int i = _liczby.Count - 1; i >= 0; i--)
            {
                if (_liczby[i] < 0)
                {
                    _liczby.RemoveAt(i);
                }
            }
        }
    }
}
