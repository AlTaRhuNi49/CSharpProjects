using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[5] { 1, 2, 3, 4, 5 };
            foreach(int items in myNumbers)
            {
                Console.WriteLine(items);
            }
            Console.ReadKey();
        }
    }
}
