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
            bool pizzaTime = true;
            pizzaTime = false;
            string pT = "abc123";
            string pA = "abc124";

            int logAttempt = 3;
            int logMax = 5;

            bool password = (pT == pA && logAttempt < logMax); //This is an equality operator. Checks if two things equal eachother
            Console.WriteLine(password);
            Console.ReadKey();
        }
    }
}
