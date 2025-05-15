using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcjezad6
{
    class Program
    {static void kwadrat(int a, char znak1, char znak2)
        {
            int i, j;
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < a; j++)
                {
                    if (i == 0 || i == a - 1 || j == 0 || j == a - 1)
                        Console.Write(znak1);
                    else
                        Console.Write(znak2);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            kwadrat(6, '#', '*');
            Console.ReadKey(true);
        }

    }
}
