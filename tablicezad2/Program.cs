using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablicezad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i, n;
            Console.WriteLine("podaj liczbe elementow tablicy <=1000");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("podaj element tablicy");
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("elementy tablicy: ");
            for (i = n-1; i>=0 ; i--)
            {
                Console.Write(tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
