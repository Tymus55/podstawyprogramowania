using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("suma kwadratów: " + (a * a + b * b));
        }
    }
}