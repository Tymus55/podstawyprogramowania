using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.Write("podaj swoje imię:");
            imie = Console.ReadLine();
            Console.WriteLine("witaj {0}!", imie);
            Console.ReadKey(true);

        }
    }
}