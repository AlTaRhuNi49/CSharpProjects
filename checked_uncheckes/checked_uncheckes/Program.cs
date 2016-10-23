using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checked_uncheckes
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked use to check if there any overflow
            //uncheck leave any overflow if there is

            byte mySbyte;                                   //0 - 255
            int myInt = 350;                                //000101011110 = 255
            //mySbyte = myInt; //this is wrong              //000011111111 = 350
            //mySbyte = checked((byte)myInt);                 //000001011110 = 94
            mySbyte = unchecked((byte)myInt);
            Console.WriteLine(mySbyte);
            Console.ReadKey();
        }
    }
}
