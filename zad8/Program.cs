using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" wyraz ciągu = " + (3 * n + 1));
            Console.ReadKey(true);
        }
    }
}