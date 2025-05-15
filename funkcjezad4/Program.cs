using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcjezad4
{
    class Program
    {
        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("liczba 0 ma cyfr: {0}", ile_cyfr(0));
            Console.WriteLine("liczba 12141421 ma cyfr: {0}", ile_cyfr(12141421));
            Console.ReadKey(true);
        }
    }
}

