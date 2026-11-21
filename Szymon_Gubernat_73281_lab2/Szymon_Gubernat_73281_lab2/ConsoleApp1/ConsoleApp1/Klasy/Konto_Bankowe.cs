using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    class Konto_Bankowe
    {
        private decimal _saldo;
        private int _liczba_operacji;
        public string Wlasciciel { get; set; }

        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Saldo nie może być mniejsze od zera");
                }
                _saldo = value;
            }
        }
        public int Liczba_Operacji
        {
            get { return _liczba_operacji; }
        }
        public Konto_Bankowe()
        {
            Wlasciciel = "N/A";
            Saldo = 0M;
            _liczba_operacji= 0;
        }
        public Konto_Bankowe(string wlasciciel,decimal saldo)
        {
            Wlasciciel = wlasciciel;
            Saldo = saldo;
            _liczba_operacji = 0;
        }
        public void Wplac(decimal Kwota)
        {
            if (Kwota <= 0)
            {
                throw new Exception("Kwota powinna być wieksza od zera");
            }
            Saldo += Kwota;
            _liczba_operacji++;
        }
        public void Wyplac(decimal Kwota)
        {
             if (Kwota > Saldo)
            {
                throw new Exception("Kwota większa od salda");
            }
           
            if(Kwota <=0)
            {
                throw new Exception("Kwota powinna być większa od zera");
            }
            Saldo-= Kwota;
            _liczba_operacji++;
        }
        public void Wyswietl_Informacje()
        {
            Console.WriteLine($"Właściciel konta: {Wlasciciel} Saldo Konta: {Saldo} Liczba Operacji: {Liczba_Operacji} ");
        }
            
    }
}
