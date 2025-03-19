using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pole={0}", a * b);
            Console.WriteLine("obwod={0}", 2 * a + 2 * b);
            Console.ReadKey(true);
        }
    }
}