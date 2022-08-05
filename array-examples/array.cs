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
            int[] hp = new int[4];
            hp[0] = 100;
            hp[1] = 100;
            hp[2] = 100;
            hp[3] = 100;

            int hp1 = 100;
            int hp2 = 100;
            int hp3 = 100;
            int hp4 = 100;

            Console.WriteLine(hp[0]);
            Console.WriteLine(hp[1]);
            Console.WriteLine(hp[2]);
            Console.WriteLine(hp[3]);

            int[] mp = new int[100]; //the same idea as above, but simplified
            for ( int i = 0; i < 100; i++)
            {
                mp[i] = 200;
                Console.WriteLine(mp[i]);
            }

            Console.ReadKey();
        }
    }
}
