using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, r = 0;
            for(int i =0; i <10; i++)
            {
                r += n;
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }
    }
}
