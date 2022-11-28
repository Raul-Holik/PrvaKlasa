using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PrvaKlasa
{
    class PrvaKlasa
    {
        private static int counter;

        public PrvaKlasa()
        {
            counter +=1;
            return;
        }
        public int Counter()
        {
            return counter;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa();
            x.Counter();            
            Console.WriteLine(x.ToString());

            Console.ReadKey();
        }
    }
}
