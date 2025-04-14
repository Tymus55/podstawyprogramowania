using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcjezad2
{
    class Program
    {
        static double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("max (6,9)={0}", max(6, 9));
            Console.WriteLine("max (2.5, 3.5)={0}", max(2.5, 3.5));
            Console.WriteLine("max (1500, 88)={0}", max(1500, 88));
            Console.ReadKey(true);
        }
        
        }
    }

