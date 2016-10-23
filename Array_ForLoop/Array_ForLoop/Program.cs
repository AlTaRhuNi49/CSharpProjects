using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 1, 2, 3, 4, 5, 6 };//first way to declare the array
            int[] myNumbers2 = new int[5];//second way to declare the array
            int[] myNumber3 = new int[5] { 1, 2, 3, 4, 5};//third way to declare the array
            Console.WriteLine(myNumbers[2]);

            for(int i=0; i < 7; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }


        }
    }
}
