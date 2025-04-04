using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whilezad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.Write("podaj x: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x<=0);
            Console.WriteLine("x={0}", x);
            Console.ReadKey(true);
        }
    }
}
