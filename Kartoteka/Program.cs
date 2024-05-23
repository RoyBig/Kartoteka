using System;
using kartoteka.impl.Kartoteka;
using kartoteka.osoba;

namespace kartoteka
{
    class Zadanie
    {
        private static Osoba podaj_dane()
        {
            Console.WriteLine("Podaj imię osoby: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko osoby: ");
            string nazwisko = Console.ReadLine();
            Osoba osoba = new Osoba(imie, nazwisko);
            return osoba;
        }
        static int Main()
        {
            Kartoteka lista = new Kartoteka();
            do
            {
                Console.WriteLine("||||||||||||||\nMENU TEKSTOWE:\n||||||||||||||\n");
                Console.WriteLine("1.Dodaj osobę\n2.Usun osobę\n3.Sprawdź rozmiar listy\n4.Sprawdź czy osoba jest na liście\n5.Zwróć osobę z listy\n6.Zakończenie działanie programu");
                Console.WriteLine("Opcja nr --> ");
                string opcja_nr = Console.ReadLine();
                switch (opcja_nr)
                {
                    case "1":
                        {
                            Osoba osoba = podaj_dane();
                            lista.dodaj(osoba);
                            Console.WriteLine("\nOsoba dodana poprawnie!\n");
                            break;
                        }
                    case "2":
                        {
                            Osoba osoba = podaj_dane();
                            if (lista.czyZawiera(osoba) == true)
                            {
                                lista.usun(osoba);
                                Console.WriteLine("\nPodana osoba została usunięta z listy!\n");
                            }
                            else Console.WriteLine("\nNie ma takiej osoby na liście!\n");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine($"\nLista zawiera " + lista.rozmiar() + " element(-y)/(-ów)\n");
                            break;
                        }
                    case "4":
                        {
                            Osoba osoba = podaj_dane();
                            if (lista.czyZawiera(osoba)) Console.WriteLine("\nDana osoba jest na liście!\n");
                            else Console.WriteLine("\nTej osoby nie ma na liście\n");
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Podaj indeks z listy: ");
                            int index = int.Parse(Console.ReadLine());
                            if (index <= lista.rozmiar() - 1)
                            {
                                Osoba osoba = lista.pobierz(index);
                                Console.WriteLine("\n" + osoba.getImie() + " " + osoba.getNazwisko() + "\n");
                            }
                            else Console.WriteLine("\nNie ma osoby o takim numerze indeksu!\n");
                            break;
                        }
                    case "6":
                        {
                            return 0;
                        }
                    default:
                        {
                            Console.WriteLine("\nPodałeś błędną liczbę!\n");
                            break;
                        }
                }
            }
            while (true);
        }
    }
}
   
