using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    abstract class Figura_3D:Figura_Geometryczna
    {
        protected Figura_3D(string nazwa) : base(nazwa)
        {

        }
        public abstract decimal Pole_Powierzchni();

        public abstract decimal Objetosc();
    }
}
