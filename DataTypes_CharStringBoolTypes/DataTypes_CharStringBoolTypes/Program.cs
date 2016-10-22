using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;

            char myVar = 'G';

            int myVarValue = 'G';
            
            Console.WriteLine("Min Char = {0} Max Char = {1} My Character = {2} \n My Variable Value = {3}", charMin, charMax, myVar, myVarValue);

            //================================================
            string myString = "this is my string varaible :p";
            Console.WriteLine(myString);

            //=============================
            bool myboolean = true;
            Console.WriteLine(myboolean);
            //=====================================================================
            //=========================challenge1====================================
            char myVariableCharChallenge1 = 'A';
            int myVariableIntChallenge1 = Convert.ToInt32('A');
            Console.WriteLine("Challenge one answer = {0}", myVariableIntChallenge1);
            //=====================================================================
            //=========================challenge2====================================
            char myVariableCharChallenge2 = 'a';
            int myVariableIntChallenge2 = Convert.ToInt32('a');
            Console.WriteLine("Challenge two answer = {0}", myVariableIntChallenge2);
            //=====================================================================
            //=========================challenge3====================================
            string myVariableStringChallenge3 = "This is My Character A value";
            Console.WriteLine("Challenge three answer = {0}", myVariableStringChallenge3);
            //=====================================================================
            //=========================challenge4====================================
            string myVariableStringChallenge4 = "This is My Character a value";
            Console.WriteLine("Challenge four answer = {0}", myVariableStringChallenge4);
            //=====================================================================
            //=========================challenge5====================================
            Console.WriteLine("Challenge five answer:- {0} = {1} and {2} = {3}", myVariableStringChallenge3, myVariableIntChallenge1, myVariableStringChallenge4, myVariableIntChallenge2);
            Console.ReadKey();
        }
    }
}
