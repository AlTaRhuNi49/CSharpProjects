using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string myAnimal = "cat";
            switch (myAnimal)
            {
                case "dog":
                    Console.WriteLine("this is dog");
                    break;
                case "bird":
                    Console.WriteLine("this is bird");
                    break;
                case "cat":
                    Console.WriteLine("this is cat");
                    break;
                default:
                    Console.WriteLine("this is default");
                    break;
            }
            Console.ReadKey();
        }
    }
}
