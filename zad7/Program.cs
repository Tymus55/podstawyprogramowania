using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NWD({0}/{1}) = {2} r: {3}", a, b, a / b, a % b);
            Console.ReadKey(true);
        }
    }
}