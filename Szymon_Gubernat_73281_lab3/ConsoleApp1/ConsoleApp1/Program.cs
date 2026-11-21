using ConsoleApp1.Klasy;
using System;
namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Konto_Klienta konto1 = new Konto_Klienta("12345678988",888m, "ID-1");
            Console.WriteLine(konto1.Dostepne_Srodki);
            konto1.Limit_Debetowy = 200M;
            Console.WriteLine(konto1.Dostepne_Srodki);
            try
            {
                konto1.Limit_Debetowy = -200;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Błąd: {e.Message}");
            }
            //konto1.Identyfikator_Konta = "ID-2"; błąd kompilacji


            Console.WriteLine("      ");
            Console.WriteLine("Zadanie 2");
            Console.WriteLine("      ");
            Pojazd_Magazynowy pojazd1 = new Pojazd_Magazynowy("RZE 88GGC",200,true);
            Pojazd_Magazynowy pojazd2 = new Pojazd_Magazynowy("RZ 88CCC", 300);
            Pojazd_Magazynowy pojazd3 = new Pojazd_Magazynowy();
            Console.WriteLine($"Liczba pojazdów: {Pojazd_Magazynowy.Pobierz_Liczbe_Pojazdow()}");

            Console.WriteLine("      ");
            Console.WriteLine("Zadanie 3");
            Console.WriteLine("      ");
            Bufor_Liczbowy bufor_l = new Bufor_Liczbowy(4);
            bufor_l[0] = 10;
            bufor_l[1] = 8;
            bufor_l[2] = 3;
            bufor_l[3] = -8;
            bufor_l[18] = 2;
            Console.WriteLine(bufor_l[18]);  
            Console.WriteLine(bufor_l[-1]);
            for (int i = 0; i < bufor_l.Pojemnosc; i++)
            {
                Console.WriteLine($"{i}: {bufor_l[i]}");
            }


            Console.WriteLine("      ");
            Console.WriteLine("Zadanie 4");
            Console.WriteLine("      ");
            Katalog_Produktow katalog = new Katalog_Produktow();
            katalog["Myszka"] = 10;
            katalog["Klawiatura"] = 5;
            katalog.Dodaj_Dostawe("Myszka", 4);   
            katalog.Dodaj_Dostawe("Klawiatura");

            string[] produkty = { "Myszka", "Klawiatura", "Monitor" };
            foreach (string p in produkty)
            {
                Console.WriteLine($"{p}: {katalog[p]}");
            }
        }
    }
}
