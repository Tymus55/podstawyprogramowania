using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkccjezad3
{
    class Program
    {
       
        
        static double pole_koła(double r)
        {
            return Math.PI * r*r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pole koła o promieniu 5 wynosi: {0}", pole_koła(5));
            Console.WriteLine("Pole koła o promieniu 10 wynosi: {0}", pole_koła(10));
            Console.WriteLine("Pole koła o promieniu 15 wynosi: {0}", pole_koła(15));
            Console.ReadKey(true);
        }
    }
}
