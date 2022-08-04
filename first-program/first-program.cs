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
            //Init Variables
            string name;
            string programmer;
            string what;
            string tough;
            string[] profession = new string[4];

            //Get Input From User
            Console.WriteLine("Welcome User");
            Console.WriteLine("Let's play a sad game of Mad Libs");
            Console.WriteLine("Please share with me your name?");
            name = Console.ReadLine();

            Console.WriteLine($"Hello {name}. What job would you like to do?");
            programmer = Console.ReadLine();

            Console.WriteLine($"Ok {name}. Since when?");
            what = Console.ReadLine();

            Console.WriteLine($"Great {name}. What 4 jobs can't you do?");
            for (int i = 0; i < profession.Length; i++)
            {
                Console.WriteLine($"Profession (plural) {i + 1} / {profession.Length}");
                profession[i] = Console.ReadLine();
            }
           
            Console.WriteLine($"Wow {name}. How was it?");
            tough = Console.ReadLine();


            //Init Story
            string madStory = 
            $"Hello, {name}. Why do you want to be a {programmer}? " +
            $"Well, it all goes back to when I was {what}. " +
           $". I was told I couldn't be {profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}, " +
            $"It was a {tough} time.";

            //Print Story
            Console.WriteLine( madStory );
            Console.ReadKey();
        }
    }
}
