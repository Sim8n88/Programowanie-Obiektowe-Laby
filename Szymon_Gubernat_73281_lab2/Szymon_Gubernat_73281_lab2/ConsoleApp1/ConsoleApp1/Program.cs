using System;
using ConsoleApp1.Klasy;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("     ");
            Samochod auto1 = new Samochod();
            Samochod auto2 = new Samochod("Audi", "A4", 2022, Enum.Typ_Paliwa.LPG);
            Samochod auto3 = new Samochod("Tesla", "Roadster", 2024, "Elektryczny");
         
            Console.WriteLine("Auto 2 przed zmianą:");
            auto2.Wyswietl_Informacje();
            auto2.Paliwo = Enum.Typ_Paliwa.Benzyna;
            Console.WriteLine("     ");
            Console.WriteLine("Auto 2 po zmianie:");
            auto2.Wyswietl_Informacje();


            Console.WriteLine("     ");
            Console.WriteLine("Auto 1");
            auto1.Wyswietl_Informacje();
            Console.WriteLine("     ");
            Console.WriteLine("Auto 3");
            auto3.Wyswietl_Informacje();



            Console.WriteLine("     ");
            Console.WriteLine("Zadanie 2");

            Konto_Bankowe konto1 = new Konto_Bankowe("Szymon", 2000);
            konto1.Wplac(2000);
            konto1.Wplac(3000);
            konto1.Wplac(8000);
            konto1.Wyplac(2000);
            konto1.Wyplac(3000);
            konto1.Wyplac(8000);
            konto1.Wyswietl_Informacje();

            try
            {
                Konto_Bankowe konto2 = new Konto_Bankowe("Adam", -2000);
                konto2.Wyswietl_Informacje();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }

            Console.WriteLine("     ");
            Console.WriteLine("Zadanie 3");
            Bilet_Do_Kina.Podsumowanie_Sprzedazy();
            Bilet_Do_Kina bilet1 = new Bilet_Do_Kina();
            Bilet_Do_Kina bilet2 = new Bilet_Do_Kina("Shrek", 5, 7, 18.50M);
            Bilet_Do_Kina bilet3 = new Bilet_Do_Kina("Lalka", 2, 13, 13.98M);
            Bilet_Do_Kina.Podsumowanie_Sprzedazy();
        }
    }
}
