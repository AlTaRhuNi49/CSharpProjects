using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 100;
            uint myUVar = 1000U;

            float myFlVar = 1.5f;
            //f can be capital (1.5F) or small (1.5f)
            double myDlVar = 100.5d;
            //d can be capital (1.5D) or small (1.5d)
            decimal myDmVar = 10000.5m;
            //m can be capital (1.5M) or small (1.5m)
            Console.WriteLine($"{myFlVar}, {myDlVar}");


        }
    }
}
