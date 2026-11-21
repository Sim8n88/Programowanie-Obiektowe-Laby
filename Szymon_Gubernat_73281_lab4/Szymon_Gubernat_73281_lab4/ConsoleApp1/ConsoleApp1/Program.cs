using ConsoleApp1.Klasy;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Samochod_Osobowy auto1 = new Samochod_Osobowy("Toyota", 2020, 123456, 5, 1.8);
            auto1.Wyswietl_Podstawowe_Informacje();
            //auto1.Numer_Seryjny = 5;
            auto1.Wyswietl_Informacje_Samochodu();
            Console.WriteLine("   ");
            Console.WriteLine("Zadanie 2");
            Wyswietlacz_Tekstu w = new Wyswietlacz_Tekstu();
            w.Wyswietl("x");
            w.Wyswietl(5);
            w.Wyswietl(10M);


            Wyswietlacz_Tekstu.Wyswietl_Licznik();

            Console.WriteLine("   ");
            Console.WriteLine("Zadanie 3");
            decimal suma = 0;
            List < Pracownik > Lista_Pracownikow= new List<Pracownik>();
            Lista_Pracownikow.Add(new Pracownik_Etatowy { Imie = "Adam", Nazwisko = "Kowalski", Stawka_Godzinowa=40M, Liczba_Godzin_Pracy_W_Miesiacu =160,Premia=888 });
            Lista_Pracownikow.Add(new Pracownik_Etatowy { Imie = "Adam", Nazwisko = "Nowak", Stawka_Godzinowa = 50M, Liczba_Godzin_Pracy_W_Miesiacu = 180, Premia = 200 });
            Lista_Pracownikow.Add(new Pracownik_Godzinowy { Imie = "Adam", Nazwisko = "Brzęczyszczykiewicz", Stawka_Godzinowa = 30M, Liczba_Godzin_Pracy_W_Miesiacu = 200});
            foreach(Pracownik pracownik in Lista_Pracownikow)
            {
                 suma += pracownik.Oblicz_Wynagrodzenie();
            }
            Console.WriteLine($"Suma wynagrodzeń pracowników: {suma}");
                
        }
    }
}
