using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilezad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i, j;
            Console.Write("podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj k: ");
            k = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= n)
            {
                j = 1;
                while (j <= k)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("");
                i++;
            }
        }
    }
}
