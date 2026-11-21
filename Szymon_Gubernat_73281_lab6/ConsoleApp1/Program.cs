using ConsoleApp1.Klasy;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("      ");
            Rejestr_Ocen oceny = new Rejestr_Ocen();
            Console.WriteLine("Podaj ocenę");
            string ocena_pom = Console.ReadLine();
            double ocena = double.Parse(ocena_pom);
            while (ocena != 0)
            {
         
                oceny.Dodaj_Ocene(ocena);
                Console.WriteLine("Podaj ocenę");
                ocena_pom = Console.ReadLine();
                ocena = double.Parse(ocena_pom);
            }
            Console.WriteLine("Oceny:");
            oceny.Wyswietl_Wszystkie();
            Console.WriteLine($"Liczba ocen:{oceny.Liczba_Ocen()}");
            Console.WriteLine($"Średnia ocen: {oceny.Oblicz_Srednia()}");
            Console.WriteLine($"Najniższa ocena: {oceny.Najnizsza_Ocena()}");
            Console.WriteLine($"Najwyższa ocena: {oceny.Najwyzsza_Ocena()}");
           
            oceny.Posortuj_Oceny();
            Console.WriteLine("Oceny:");
            oceny.Wyswietl_Wszystkie();

            Console.WriteLine("      ");
            Console.WriteLine("Zadanie 2");
            Console.WriteLine("      ");
            Magazyn_Produktow magazyn = new Magazyn_Produktow();
            magazyn.Dodaj_Produkt("Piłka", 888);
            magazyn.Dodaj_Produkt("Książka", 400);
            magazyn.Dodaj_Produkt("Zeszyt", 300);
            magazyn.Dodaj_Produkt("Długopis",200);
            magazyn.Dodaj_Produkt("Ołówek", 100);
            Console.WriteLine("Podaj kod produktu:");
            string kod_produktu = Console.ReadLine();
            int? ilość = magazyn.Pobierz_Stan(kod_produktu);
            if (ilość != null)
            {
                Console.WriteLine($"Ilość {kod_produktu} to: {ilość}");
            }
            else
            {
                Console.WriteLine($"{kod_produktu} nie ma");
            }
            
            magazyn.Zaktualizuj_Stan("Piłka", 200);
            magazyn.Wyswietl_Raport();

            Console.WriteLine("      ");
            Console.WriteLine("Zadanie 3");
            Console.WriteLine("      ");

            List<string> slowa = new List<string> { "jablko", "banan", "jablko", "gruszka", "banan", "jablko" };
            Analizator_Tekstu analizator = new Analizator_Tekstu(slowa);
            analizator.Przelicz_Wystapienia();
            analizator.Wyswietl_Wyniki();
            Console.WriteLine("      ");
            Console.WriteLine("Zadanie 4");
            Console.WriteLine("      ");
            int[] kolekcja_tab = new int[] { 12, -5, 0, 8, -3, 19, -1, 4 };
            Kolekcja_Liczb kolekcja = new Kolekcja_Liczb(kolekcja_tab);
            Console.WriteLine("Kolekcja liczb:");
            kolekcja.Wyswietl_Liczby();
            List<int> ujemne = kolekcja.Pobierz_Ujemne();
            Console.WriteLine("Liczby ujemne:");
            foreach(int liczba_ujemna in ujemne)
            {
                Console.Write($"{liczba_ujemna}, ");
            }
            Console.WriteLine();
            kolekcja.Usun_Ujemne();
            Console.WriteLine("Po usunięciu ujemnych:");
            kolekcja.Wyswietl_Liczby();

            Console.WriteLine("      ");
            Console.WriteLine("Zadanie 5");
            Console.WriteLine("      ");
            Ksiazka_Telefoniczna ksiazka_telefoniczna = new Ksiazka_Telefoniczna();
            ksiazka_telefoniczna.Dodaj_Kontakt("Kowalski", new List<string> { "111-222-333", "444-555-666" });
            ksiazka_telefoniczna.Dodaj_Kontakt("Nowak", new List<string> { "111-888-333", "444-999-666" });
            ksiazka_telefoniczna.Dodaj_Kontakt("Kowal", new List<string> { "111-111-333", "444-222-666" });
            ksiazka_telefoniczna.Dodaj_Numer("Kowalski", "888-888-888");
            ksiazka_telefoniczna.Dodaj_Numer("Wiśniewski", "888-888-888");
            ksiazka_telefoniczna.Wyswietl_Kontakty();
        }
    }
}
