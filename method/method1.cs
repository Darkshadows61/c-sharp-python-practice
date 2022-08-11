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
            int myHP = 10;
            int enemyHP = 30;
            int money = 0;
            bool hitLegs = true;
            bool hitArms = true;
            bool hitHead = true;
            
            if (hitLegs)
            {
                hitEvent();
            }

            if (hitArms)
            {
                hitEvent();
            }

            if (hitHead)
            {
                hitEvent();
            }

            Console.WriteLine(enemyHP);
            Console.WriteLine(myHP);
            Console.WriteLine(money);
            Console.ReadKey();

            void hitEvent()
            {
                enemyHP -= 1;
                money += 5;
                myHP += 2;
            }
        }
    }
}
