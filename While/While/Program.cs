using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, r = 0, i = 0;
            while(i<10)
                {
                r += n;
                i++;
            }
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
