using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicit_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte mySbyte;                                   //0 - 255
            int myInt = 350;                                //000101011110 = 255
            //mySbyte = myInt; //this is wrong              //000011111111 = 350
            mySbyte = (byte)myInt;                          //000001011110 = 94
            Console.WriteLine(mySbyte);
            Console.ReadKey();


        }
    }
}
