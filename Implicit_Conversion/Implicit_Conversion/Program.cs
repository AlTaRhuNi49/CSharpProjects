using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long var = 299;
            float var1 = var;
            Console.WriteLine(var1);

            char var2 = 'G';
            int var3 = var2;
            Console.WriteLine(var3);

            Console.ReadKey();
        }
    }
}
