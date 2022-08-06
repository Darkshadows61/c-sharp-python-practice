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
            // for (init your vaiable; set your condition; give a command)
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            string[] fileName = new String[700];
            string masterData = "";

            for (int i = 0; i < fileName.Length; i++)
            {
                fileName[i] = $"Candy data {i + 1}.txt";
                masterData += ReadData(fileName[i]);
            }
            Console.WriteLine(masterData);
            Console.ReadKey();

            string ReadData(string read)
            {
                return $"candy data from {read}\n";
            }

            while (true)
            {
                //while loop, whatever comes after only happens if while is met
            }
        }
    }
}
