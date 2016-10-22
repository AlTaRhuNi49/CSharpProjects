using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //=, +=, -=, *=, /=, %=

            int myVar1 = 7, myVar2 = 8;

            //myVar1 = myVar2;  temp = myVar1 + myVar2
            //Console.WriteLine(myVar1);
            //=====================
            myVar1 += myVar2;
            Console.WriteLine(myVar1);
            Console.ReadKey();
        }
    }
}
