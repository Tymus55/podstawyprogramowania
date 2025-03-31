using System;

namespace tablicezad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            int i = 0, j, liczba;
            Console.Write("podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            while (liczba > 0)
            {
                tab[i++] = liczba % 2;
                liczba /= 2;
            }

            for (j = i - 1; j >= 0; j--)
            {
                Console.Write(tab[j]);
            }

            Console.ReadKey(true);
        }
    }
}