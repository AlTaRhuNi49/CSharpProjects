using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_FloatPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("Min Value = {0} Max val = {1}", flMin, flMax);

            float flVal = 1F / 3;
            double dlVal = 1D / 3;
            decimal dcVal = 1M / 3;
            Console.WriteLine("\nfloat value = {0}\n double value = {1}\n decimal value = {2}", flVal, dlVal, dcVal);
            Console.ReadKey();
        }
    }
}
