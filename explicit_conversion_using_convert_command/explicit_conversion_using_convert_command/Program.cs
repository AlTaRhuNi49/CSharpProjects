using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicit_conversion_using_convert_command
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDoubleVar = 230.34D;
            string myString, subString;
            myString = Convert.ToString(myDoubleVar); //convert double to string using (convert.ToString).
            subString = myString.Substring(0, 2);//cut peace of string using (variableName.Substring(0=index to start, 2 = how many number of index))
            Console.WriteLine(myDoubleVar);
            Console.WriteLine(myString);
            Console.WriteLine(subString);
            Console.ReadKey();
        }
    }
}
