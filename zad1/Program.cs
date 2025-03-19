using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("podaj a");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("liczba jest nieparzysta");
            }
            Console.ReadKey(true);
        }
    }
}