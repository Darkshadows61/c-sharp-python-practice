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
            char a = 'a'; //cannot use double quotes here because they are used for strings only
            char b = '\n'; //escape character, but you cannot have anything else in with it.
            string c = "" + a + a ; //concatonation. the double quotes tell it whats going on
            char d = '\r'; //returns back to the line before
            char e = '\t'; //tab
            char f = '\''; //single quite
            char g = '\"'; //double quote
            char h = '\\'; //backslash

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(a);


            Console.ReadKey();
        }
    }
}
