using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int var = 10;
            //string result = (var < 9) ? "less than 9" : "more than 9";
            //Console.WriteLine(result);
            //Console.ReadKey();
            //===============================

            string myName = "meda", result;
            result = (myName.Equals("meda")) ? "yes" : "no";
            //.Equals use for comparing between strings
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
