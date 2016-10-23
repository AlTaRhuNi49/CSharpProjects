using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadLine , Read
            //========================ReadLine==============
            //string myName;
            //int var1, var2;
            //Console.WriteLine("enter ur name");
            //myName = Console.ReadLine();//read line of what u type
            //Console.WriteLine("\n please enter ur number fast");
            //var1 = Convert.ToInt32(Console.ReadLine());//read the number as string so that's why need to be converted
            //Console.WriteLine("hello my herro {0}  and ur number {1}", myName, var1);
            //===================Read================
            int var;
            Console.WriteLine("enter");
            var = Console.Read();
            Console.WriteLine(var);
            Console.ReadKey();
        }
    }
}
