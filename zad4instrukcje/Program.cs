﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, min, max;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj d: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj e: ");
            e = Convert.ToDouble(Console.ReadLine());
            min = a;

            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("liczba {0} jest najmniejsza", min);
            max = a;

            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("liczba {0} jest największa", max);
            Console.ReadKey(true);




        }
    }
}