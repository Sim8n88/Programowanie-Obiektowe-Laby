using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1.Klasy
{
    public class Analizator_Tekstu
    {
        private List<string> _slowa;
        private Dictionary<string, int> _czestosc_slow;
        public Analizator_Tekstu(IEnumerable<string> slowa)
        {
            _slowa = new List<string>();
            _slowa.AddRange(slowa);
            _czestosc_slow = new Dictionary<string, int>();
        }
        public void Przelicz_Wystapienia()
        {
            foreach(string slowo in _slowa)
            {
                if (_czestosc_slow.ContainsKey(slowo))
                {
                    _czestosc_slow[slowo] += 1;
                }
                else
                {
                    _czestosc_slow.Add(slowo, 1);
                }
            }
        }
        public void Wyswietl_Wyniki()
        {
            foreach(KeyValuePair <string,int> para in _czestosc_slow)
            {
                Console.WriteLine($"Słowo {para.Key} ilość wystąpień: {para.Value}");
            }
        }
    }
}
