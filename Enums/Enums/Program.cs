using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum humanSex : sbyte//this is the type on data if u didn't determined so will give int by default
        {
            male = 1,
            female = 2
        }

        static void Main(string[] args)
        {
            sbyte var1;
           
            humanSex var2 = humanSex.female;

            Console.WriteLine(var2);
            var1 = Convert.ToSByte(var2);
            Console.WriteLine(var1);
            Console.ReadKey();


        }
    }
}
