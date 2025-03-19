using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("podaj liczbe całkowitą");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("liczba jest dodatnia");
            }
            else if (a < 0)
            {
                Console.WriteLine("liczba jest ujemna");
            }
            else
            {
                Console.WriteLine("liczba jest równa zero");
            }
            Console.ReadKey(true);

        }
    }
}