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
            if (true) 
            {
                Console.WriteLine("hello");
                if (true)
                {
                    Console.WriteLine("nested!");
                }
                Console.WriteLine("hello");
            }

            if (false)
            {
                Console.WriteLine("Its false!");
            }
            else
            {
                Console.WriteLine("Its true!");
            }

            if (true)
            {
                Console.WriteLine("Its true!");
            }
            else if (true)
            {
                Console.WriteLine("Its true!");
            }
            else
            {
                Console.WriteLine("Its false!");
            }
            Console.ReadKey();
        }
    }
}
