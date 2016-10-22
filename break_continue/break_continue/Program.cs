using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, r = 0;
            for (int i = 0; i < 10; i++)
            {
                r += n;
                Console.WriteLine(r);
                if (i > 6)
                    break;
                if (i>3)
                continue;
                
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("inside loop");
                }
            }
            Console.ReadKey();
        }
    }
}
