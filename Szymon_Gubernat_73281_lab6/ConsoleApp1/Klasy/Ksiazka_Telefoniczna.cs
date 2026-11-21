using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    public class Ksiazka_Telefoniczna
    {
        private Dictionary<string, List<string>> _kontakty;
        public Ksiazka_Telefoniczna() 
        {
            _kontakty = new Dictionary<string, List<string>>();
        }
        public void Dodaj_Kontakt(string nazwisko, List<string> numery_telefonow)
        {
            _kontakty.Add(nazwisko, numery_telefonow);
        }
        public void Dodaj_Numer(string nazwisko,string nowy_numer)
        {
            if(_kontakty.TryGetValue(nazwisko,out List <string> value))
            {
                value.Add(nowy_numer);
            }
            else
            {
                Console.WriteLine("Brak kontaktu w bazie");
            }
        }
        public void Wyswietl_Kontakty()
        {
            foreach(KeyValuePair<string, List<string>> para in _kontakty)
            {
                Console.WriteLine(para.Key);
                foreach (string numer in para.Value)
                {
                    Console.WriteLine(numer);
                }
            }
        
        }
    }
}
