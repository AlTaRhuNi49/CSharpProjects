using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            double mySalary = 200.0, total = 0.0;
            int i = 0;
            do
            {
                total += mySalary;
                i++;
            } while (i < 10);
            Console.WriteLine(total);
            Console.ReadKey();

        }
    }
}
