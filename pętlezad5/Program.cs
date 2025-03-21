using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pętlezad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.Write("podaj liczbę naturalną n większą od 1: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
