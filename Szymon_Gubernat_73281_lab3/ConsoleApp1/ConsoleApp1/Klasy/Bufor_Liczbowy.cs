using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Bufor_Liczbowy
    {
        private readonly int[] _liczby;
        public  int Pojemnosc {
            get { 
                return _liczby.Length;
            } 
        
        }
        public Bufor_Liczbowy(int rozmiar)
        {

            _liczby = new int[rozmiar];
        }
        public int this[int index]
        {
            get
            {
                if (index < _liczby.Length && index>=0)
                {
                    return _liczby[index];

                }
                return -1;
            }
            set
            {
                if(index<_liczby.Length && value >= 0 && index >= 0)
                {
                    _liczby[index] = value;
                }
            }
        }
    }
}
