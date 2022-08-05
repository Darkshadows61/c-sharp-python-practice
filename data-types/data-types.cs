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
            bool a = true;
            char b = 'b';
            string c = "string c";
            int d = 7;
            float e = 0.77f;

            int enemyHP = 50;
            bool hurt = true;
            bool flashing = true;
            bool dizzy = true;
            int dmg = 6;

            if (hurt)
            {
                enemyHP -= dmg;
            }

            if (flashing)
            {
                enemyHP -= dmg;
            }
            
            if (dizzy)
            {
                enemyHP -= dmg;
            }

            Console.WriteLine(enemyHP);

            Console.ReadKey();
        }
    }
}
