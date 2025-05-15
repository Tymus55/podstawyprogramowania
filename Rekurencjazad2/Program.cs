using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurencjazad2
{
    using System;

    namespace UczniowieApp
    {
        struct Uczen
        {
            public string imie;
            public string nazwisko;
            public int[] oceny;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Podaj liczbę uczniów: ");
                int liczbaUczniow = int.Parse(Console.ReadLine());

                Uczen[] uczniowie = new Uczen[liczbaUczniow];

                for (int i = 0; i < liczbaUczniow; i++)
                {
                    Console.WriteLine($"\nUczeń #{i + 1}");

                    Console.Write("Imię: ");
                    uczniowie[i].imie = Console.ReadLine();

                    Console.Write("Nazwisko: ");
                    uczniowie[i].nazwisko = Console.ReadLine();

                    Console.Write("Ile ocen chcesz wprowadzić dla tego ucznia? ");
                    int liczbaOcen = int.Parse(Console.ReadLine());

                    uczniowie[i].oceny = new int[liczbaOcen];

                    for (int j = 0; j < liczbaOcen; j++)
                    {
                        Console.Write($"Ocena {j + 1}: ");
                        uczniowie[i].oceny[j] = int.Parse(Console.ReadLine());
                    }
                }

                // Wyświetlenie danych
                Console.WriteLine("\n--- Dane uczniów ---");

                for (int i = 0; i < liczbaUczniow; i++)
                {
                    Console.WriteLine($"\nUczeń #{i + 1}: {uczniowie[i].imie} {uczniowie[i].nazwisko}");
                    Console.Write("Oceny: ");
                    foreach (int ocena in uczniowie[i].oceny)
                    {
                        Console.Write($"{ocena} ");
                    }
                    Console.WriteLine();
                }

                Console.ReadKey(true);
            }
        }
    }
}
