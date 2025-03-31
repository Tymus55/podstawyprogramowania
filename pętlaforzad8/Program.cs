using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pętlaforzad8
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok1, rok2, i;
            Console.WriteLine("Podaj pierwszy rok: ");
            rok1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugi rok: ");
            rok2 = Convert.ToInt32(Console.ReadLine());
            for (i = rok1; i <= rok2; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(true);
        }
    }
}
