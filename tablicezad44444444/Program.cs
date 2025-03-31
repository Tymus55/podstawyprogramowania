using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablicezad4444
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];

            int i;
            int n, suma;
            Console.WriteLine("podaj liczbe elementow tablicy <=1000");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("podaj element tablicy");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (i = 0; i < n; i++)
            {
                suma = suma + tab[i];
            }
            Console.WriteLine("suma elementow tablicy: " + suma);
            Console.ReadKey(true);
        }
    }
}