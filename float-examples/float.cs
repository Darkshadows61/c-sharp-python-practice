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
            float a = 0.77f; //you have to add an f at the end of a float
            a++; //increment by 1 operator
            a += 3.34f;
            a = a + 3.43f;
            Console.WriteLine(a);

            float b = 2.1f;
            b--; // decrement operator
            Console.WriteLine(b);

            float c = 3.43f;
            c *= 2; //multiply
            Console.WriteLine(c);

            float d = 5.01f;
            d /= 2; //divide
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
