using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcjezad5
{
    class Program
    {static int czy_pierwsza(int liczba)
        { int i;
        for (i = 2; i < liczba / 2; i++)
            if (liczba % i == 0)
                    return 0;
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 2 jest pierwsza: {0}", czy_pierwsza(2));
            Console.WriteLine("Liczba 3 jest pierwsza: {0}", czy_pierwsza(3));
            Console.WriteLine("Liczba 4 jest pierwsza: {0}", czy_pierwsza(4));
            Console.WriteLine("Liczba 5 jest pierwsza: {0}", czy_pierwsza(5));
            Console.WriteLine("Liczba 6 jest pierwsza: {0}", czy_pierwsza(6));
            Console.ReadKey(true);
        }
    }
}
