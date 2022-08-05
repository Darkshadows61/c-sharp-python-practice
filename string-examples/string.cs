using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            Console.WriteLine(a);
            Console.WriteLine(a[0]); //strings are just arrays of characters
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]); // simple for loop to break out a string so it looks like each is typed seperately
            }
            
            a += '!'; //adds a ! to the string
            Console.WriteLine(a);

            string escapeChar = "\n \t \' \" \\"; //new line, tab, single quote, double quote, double \\
            Console.WriteLine(escapeChar);

            string name = "Tom";
            name = name.ToLower(); //lower case, smae can be done to Uppercase
            string b = $"Hello {name}! "; //interpolated string
            Console.WriteLine(b);

            name = "Tho,mas";
            string[] name2 = name.Split(','); //splits a string at a given point such as ,
            Console.WriteLine(name2[0]);
            Console.WriteLine(name2[1]);

            name = "I like turtles";
            bool does = name.Contains("like"); //Returns a bool if the string name contains the word like
            Console.WriteLine(does);

            Console.ReadKey();
        }
    }
}
