using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathoperationspart1
{
    class Program
    {
        static void Main(string[] args)
        {

            //+ - / * %

            int var1 = 22;
            int var2 = 93;
            int result1 = var1 + var2;
            Console.WriteLine(result1);

            int result2 = var2 - var1;
            Console.WriteLine(result2);

            int result3 = var1 * var2;
            Console.WriteLine(result3);

            int result4 = var2 / var1;
            Console.WriteLine(result4);

            int result5 = var2 % var1;
            Console.WriteLine(result5);

            //unary operators: + -
            int temp = -var1;
            Console.WriteLine(temp);

            Console.ReadKey();
        }
    }
}
