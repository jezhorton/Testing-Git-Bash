using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LoopWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, finalScore = 0, test = 0;
            int[] score = new int[100];
            
            bool yass = true;
            string entered = Console.ReadLine();
            for (int i = 1; i <= 100; i++)
            {
                finalScore = finalScore + i;
                if (i % 3 == 0 && i < 25)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(finalScore);
            foreach (int c in score)
            {
                finalScore = c + finalScore;
                Console.WriteLine(finalScore);
            }
            /*foreach (char c in entered) //For each loop
            {
                Console.WriteLine(c);
            }
            foreach (int c in score)
            {
                Console.WriteLine(score[c]);
                finalScore = finalScore + c;
                Console.WriteLine(finalScore);
            }
            while (yass) //while loop
            {
                x++;
                Console.WriteLine("Value of x: " + x);
                if (x == 20) { yass = false; }
            }
            do //Makes the code run at least once even if the condition is false
            {
                x++;
            } while (x > 25);#
            */
            Console.ReadKey();

        }
    }
}
