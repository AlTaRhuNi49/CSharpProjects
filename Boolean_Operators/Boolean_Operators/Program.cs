using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean Comparison ==, !=, <, >, <=, >=
            //Boolean Condition &&, ||

            bool myResult;
            bool myResult2;
            int myVar1 = 5, myVar2 = 6;
            myResult = myVar1 < myVar2;
            Console.WriteLine(myResult);

            myResult2 = (myVar1 == 5) && (myVar2 == 6);
            Console.WriteLine(myResult2);
            Console.ReadKey();
        }
    }
}
