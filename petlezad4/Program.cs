using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlezad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, k;
            Console.Write("podaj liczbę naturalną n dodatnią: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj liczbę naturalną dodatnią k: ");
            k = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= k; j++)
                    Console.Write("*"); 
                Console.WriteLine("");
            }

            Console.ReadKey(true); 
    }
    }
}
