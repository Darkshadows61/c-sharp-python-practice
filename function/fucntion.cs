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
            string[] name = new string[3];

            name[0] = "Johnny";
            name[1] = "Carla";
            name[2] = "Zack";

            Surname(0, "Mr. ");
            Surname(1, "Mrs. ");
            Surname(2, "Mr. ");

            Console.ReadKey();

            // OUR PROGRAM ENDS HERE

            void Surname(int ind, string sur)
            {
                name[ind] = sur + name[ind];

                Console.WriteLine(name[ind]);
            }

        }
    }
}
