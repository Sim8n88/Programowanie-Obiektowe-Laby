using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
     class Konto_Klienta
    {
        private readonly string _numer_pesel;
        private decimal _saldo;
        public string Pesel { get {return _numer_pesel; } }
        public string Identyfikator_Konta { get; init; }
        private decimal _limit_debetowy;
        public decimal Limit_Debetowy { get {return _limit_debetowy ; }
            set {
                if (value < 0)
                {
                    throw new Exception("Limit debetowy musi być >=0");
                }
                else
                {
                    _limit_debetowy = value;
                }
            } 
        }
        public decimal Dostepne_Srodki
        {
            get {return _saldo + _limit_debetowy; }
        }
        public Konto_Klienta(string pesel, decimal saldo,string identyfikator_konta)
        {
           _numer_pesel = pesel;
            _saldo = saldo;
            Identyfikator_Konta = identyfikator_konta;
          
        }
    }
}
