using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilezad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            Console.Write("podaj a: ");
                a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i <= b)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey(true);
        }
    }
}
