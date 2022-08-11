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
            string inv1 = "empty";
            string inv2 = "empty";
            string inv3 = "empty";
            string pickup1 = "Pizza";
            string pickup2 = "Candy";

            PickupPizzaI1();
            PickupCandyI3();

            Console.WriteLine(inv1);
            Console.WriteLine(inv2);
            Console.WriteLine(inv3);
            Console.ReadKey();

            //PROGRAM ENDS HERE

            void PickupPizzaI1()
            {
                if (inv1 == "empty")
                {
                    inv1 = pickup1;
                    // UI
                    // VFX
                    // Update Slot 1
                    // Update Slot 2
                }
            }
            void PickupCandyI3()
            {
                if (inv3 == "empty")
                {
                    inv3 = pickup2;
                    // UI
                    // VFX
                    // Update Slot 1
                    // Update Slot 2
                }
            }

        }
    }
}
