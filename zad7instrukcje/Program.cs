using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("podaj liczbę arabską od 1 do 3999");
            a = Convert.ToInt32(Console.ReadLine());
            if (a >= 3000) { a -= 3000; Console.Write("MMM"); }
            if (a >= 2000) { a -= 2000; Console.Write("MM"); }
            if (a >= 1000) { a -= 1000; Console.Write("M"); }
            if (a >= 900) { a -= 900; Console.Write("CM"); }
            if (a >= 500) { a -= 500; Console.Write("D"); }
            if (a >= 400) { a -= 400; Console.Write("CD"); }
            if (a >= 100) { a -= 100; Console.Write("C"); }
            if (a >= 90) { a -= 90; Console.Write("XC"); }
            if (a >= 50) { a -= 50; Console.Write("L"); }
            if (a >= 40) { a -= 40; Console.Write("XL"); }
            if (a >= 10) { a -= 10; Console.Write("X"); }
            switch (a)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
            }
            Console.ReadKey(true);
        }




    }
}
