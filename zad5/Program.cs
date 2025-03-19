using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, l, v, Pc;
            Console.Write("podaj r:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj h:");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            v = 1.0 / 3.0 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("l={0}, v={1}, Pc={2}", l, v, Pc);
            Console.ReadKey(true);

        }
    }
}