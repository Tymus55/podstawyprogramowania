﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a^3={0}", a * a * a);
            Console.ReadKey(true);
        }
    }
}