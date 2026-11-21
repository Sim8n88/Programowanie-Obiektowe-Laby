using ConsoleApp1.Klasy;
using ConsoleApp1.Klasy.Klasy_do_zadania_2;
using System;
namespace ConsoleApp1
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            List<Figura_Geometryczna> figury_geometryczne = new List< Figura_Geometryczna> ();
            Kwadrat kwadrat = new Kwadrat(6.25M);
            Kolo kolo = new Kolo(3.33M);
            Szescian szescian = new Szescian(8.88M);
            figury_geometryczne.Add(kwadrat);
            figury_geometryczne.Add(kolo);
            figury_geometryczne.Add(szescian);
            foreach(Figura_Geometryczna figura_geometryczna in figury_geometryczne)
            {
                figura_geometryczna.Wyswietl_Informacje();
            }
            Console.WriteLine("        ");
            Console.WriteLine("Zadanie 2");
            List<Pojazd> pojazdy = new List<Pojazd>();
            Samochod samochod1 = new Samochod("Opel", 2005, 43.4M,10M);
            Samochod samochod2 = new Samochod("Audi", 2010, 45.4M,13M);
            Samolot samolot1 = new Samolot("Boeing", 2015, 2, 12500M);
            Samolot samolot2 = new Samolot("Cessna", 2008, 1, 4200M);
            Motocykl motocykl1 = new Motocykl("Zero", 2022, 14.4M, 7.2M);
            Motocykl motocykl2 = new Motocykl("Energica", 2021, 21.5M, 10.8M);
            pojazdy.Add(samochod1);
            pojazdy.Add(samochod2);
            pojazdy.Add(samolot1);
            pojazdy.Add(samolot2);
            pojazdy.Add(motocykl1);
            pojazdy.Add(motocykl2);
            foreach(Pojazd pojazd in pojazdy)
            {
                pojazd.Wyswietl_Informacje();
            }
            List<I_Tankowalny> tankowalne = new List<I_Tankowalny>();
            tankowalne.Add(samochod1);
            tankowalne.Add(samochod2);
            tankowalne.Add(samolot1);
            tankowalne.Add(samolot2);
            foreach(I_Tankowalny tankowalny in tankowalne)
            {
                tankowalny.Zatankuj(30.88M);
            }
        }
    }
}
