using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablicezad6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dni = new string[] { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
            foreach (string dzien in dni)
            {
                Console.WriteLine(dzien);
            }
        }
    }
}
