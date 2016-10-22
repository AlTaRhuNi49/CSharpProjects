using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //\' \" \\ \0 \a \b \n \r \t \v \f
            //1- \0 means this is the end of string it would not print anything
            string myString1 = "this is my string var\a";
            Console.WriteLine(myString1);
            //2- \a makes sound when you implement the code 
            string myString2 = "this is my string var\a";
            Console.WriteLine(myString2);
            //3- \b backspace delete one letter back
            string myString3 = "this is my string va\br";
            Console.WriteLine(myString3);
            //4- \b new line make new line
            string myString4 = "this is\n my string var";
            Console.WriteLine(myString4);
            //5- \n new line make new line
            string myString5 = "this is\n my string var";
            Console.WriteLine(myString5);
            //6- \r deletes all string back and keep whatever after
            string myString6 = "this is\r my string var";
            Console.WriteLine(myString6);
            //7- \t tab make space tab
            string myString7 = "7- this is\t my string var";
            Console.WriteLine(myString7);
            //8- \v make something strange 
            string myString8 = "8- this is\v my string var";
            Console.WriteLine(myString8);
            //9- \f make something strange too
            string myString9 = "9- this is\f my string var";
            Console.WriteLine(myString9);

            //10- @ 
            string myString10 = @"C:\Users\user\Documents\Visual Studio 2015\Projects\c#";
            Console.WriteLine(myString10);

            // cantocate two strings
            string myStringAll = myString6 + myString7 + myString8 + myString9 + myString10;
            Console.WriteLine(myStringAll);
            Console.ReadKey();
        }
    }
}
