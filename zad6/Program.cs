using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Różnica: " + roznica);
            Console.WriteLine("Iloczyn: " + iloczyn);
            Console.WriteLine("Iloraz: " + iloraz);
            Console.ReadKey(true);
        }
    }
}