using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if ((a <= b) && (b <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", b);
            else
                Console.WriteLine("Liczba {0} jest najmniejsza", c);
            if ((a >= b) && (b >= c))
                Console.WriteLine("Liczba {0} jest największa", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("Liczba {0} jest największa", b);
            else
                Console.WriteLine("Liczba {0} jest największa", c);
            Console.ReadKey(true);

        }
    }
}