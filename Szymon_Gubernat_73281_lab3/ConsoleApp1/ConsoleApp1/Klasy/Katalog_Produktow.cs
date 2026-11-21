using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Katalog_Produktow
    {
        private Dictionary<string, int> _magazyn = new Dictionary<string, int>();
        public int this[string nazwa_produktu]
        {
            get
            {
                if (_magazyn.ContainsKey(nazwa_produktu))
                {
                    return _magazyn[nazwa_produktu];
                }
                return 0;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wartość jest ujemna błąd");
                }
                else
                {
                    if (_magazyn.ContainsKey(nazwa_produktu))
                    {
                        _magazyn[nazwa_produktu] = value;
                    }
                    else
                    {
                        _magazyn.Add(nazwa_produktu, value);
                    }
                }
            }
        }
         public void Dodaj_Dostawe(string nazwa_produktu, int ilosc)
        {
            this[nazwa_produktu] = this[nazwa_produktu] + ilosc;
        }

        public void Dodaj_Dostawe(string nazwa_produktu)
        {
            Dodaj_Dostawe(nazwa_produktu, 1);
        }


    } 
}
