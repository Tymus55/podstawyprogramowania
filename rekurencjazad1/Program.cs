using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurencjazad1
{
    struct osoba
    {
        public string imie, nazwisko;
        public int rok_urodzenia;
    }

    class Program
    {
        static void Main(string[] args)
        {
            osoba o;

            Console.WriteLine("Podaj imie:");
            o.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            o.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj rok urodzenia:");
            o.rok_urodzenia = int.Parse(Console.ReadLine());

            Console.WriteLine($"Imie: {o.imie}, Nazwisko: {o.nazwisko}, Rok urodzenia: {o.rok_urodzenia}");

            Console.ReadKey(true);
        }
    }
}
