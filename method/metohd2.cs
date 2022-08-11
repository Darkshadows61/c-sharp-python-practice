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
            float userRank = 0;
            bool guess = true;
            int page = 3;
            int textLength = 100;

            userRank = Score();

            Console.WriteLine(userRank);
            Console.ReadKey();
            
            float Score()
            {
                float temp = 0;

                if (guess)
                {
                    temp -= 11;

                    if (page < 3)
                    {
                        temp += 40;
                    }
                    else
                    {
                        temp += 20;
                    }
                }
                else
                {
                    temp -= 11;

                    if (page < 3)
                    {
                        temp += 40;
                    }
                    else
                    {
                        temp += 20;
                    }
                    if (textLength > 50)
                    {
                        temp += 40;
                    }
                } return temp;
            }
        }
    }
}
