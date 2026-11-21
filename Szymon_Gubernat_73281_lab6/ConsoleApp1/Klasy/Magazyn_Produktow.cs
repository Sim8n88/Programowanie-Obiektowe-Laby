using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    public class Magazyn_Produktow
    {
        private Dictionary<string, int> _stany_magazynowe;
        public Magazyn_Produktow()
        {
            _stany_magazynowe = new Dictionary<string, int>();
        }
        public void Dodaj_Produkt(string kod_produktu,int liczba_sztuk)
        {
            _stany_magazynowe.Add(kod_produktu, liczba_sztuk);
        }
        public int? Pobierz_Stan(string kod_produktu)
        {
            if(_stany_magazynowe.TryGetValue(kod_produktu,out int liczba_sztuk))
            {
                return liczba_sztuk;
            }
            else
            {
                return null;
            }
        }
        public void Zaktualizuj_Stan(string kod_produktu,int dodatkowa_liczba_sztuk)
        {
            if (_stany_magazynowe.ContainsKey(kod_produktu))
            {
                _stany_magazynowe[kod_produktu] += dodatkowa_liczba_sztuk;
            }
        }
        public void Wyswietl_Raport()
        {
            foreach(KeyValuePair < string, int > para in _stany_magazynowe)
            {
                Console.WriteLine($"Produkt: {para.Key} ilość sztuk: {para.Value}");
            }
        }
    }
}
