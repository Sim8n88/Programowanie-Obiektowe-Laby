using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    abstract class Figura_Geometryczna
    {
        public string Nazwa { get; protected set; }
        protected Figura_Geometryczna(string nazwa)
        {
            Nazwa = nazwa;
        }
        public abstract void Wyswietl_Informacje();

    }
}
