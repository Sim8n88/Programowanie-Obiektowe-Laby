using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
     abstract class Figura_2D:Figura_Geometryczna
    {
        protected Figura_2D(string nazwa) : base(nazwa)
        {

        }
        public abstract decimal Pole();
        public abstract decimal Obwod();

    }
}
