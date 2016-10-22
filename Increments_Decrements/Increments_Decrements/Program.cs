using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments_Decrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 2;
            int temp = ++var;
            int temp2 = --var;
            Console.WriteLine(temp);
            Console.WriteLine(temp2);
            Console.ReadKey();
        }
    }
}
