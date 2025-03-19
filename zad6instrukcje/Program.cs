using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int miesiąc;
            Console.WriteLine("podaj numer miesiąca");
            miesiąc = Convert.ToInt32(Console.ReadLine());
            if (miesiąc == 1)
            {
                Console.WriteLine("Styczeń");
            }
            else if (miesiąc == 2)
            {
                Console.WriteLine("Luty");
            }
            else if (miesiąc == 3)
            {
                Console.WriteLine("Marzec");
            }
            else if (miesiąc == 4)
            {
                Console.WriteLine("Kwiecień");
            }
            else if (miesiąc == 5)
            {
                Console.WriteLine("Maj");
            }
            else if (miesiąc == 6)
            {
                Console.WriteLine("Czerwiec");
            }
            else if (miesiąc == 7)
            {
                Console.WriteLine("Lipiec");
            }
            else if (miesiąc == 8)
            {
                Console.WriteLine("Sierpień");
            }
            else if (miesiąc == 9)
            {
                Console.WriteLine("Wrzesień");
            }
            else if (miesiąc == 10)
            {
                Console.WriteLine("Październik");
            }
            else if (miesiąc == 11)
            {
                Console.WriteLine("Listopad");
            }
            else if (miesiąc == 12)
            {
                Console.WriteLine("Grudzień");
            }
            else
            {
                Console.WriteLine("Nie ma takiego miesiąca");
            }
            Console.ReadKey(true);

        }
    }
}