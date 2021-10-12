using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingMisery
{
    class cycles
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            /*string[] students = new string[18] { "Artem", "Artjom", "Nikita", "Aleksei", "Isabel", "Aljona", "Erik", "Maksim T.", "Daniil", "Maksim L.", "Georg", "Nicole", "Nikolai", "Rolan", "Jaan", "Ilja", "Andrei", "Daniel" };
            int num = 0;
            Console.WriteLine("\nWhile");
            while (num <18)
            {
                Console.WriteLine($"Hello {students[num]}");
                num +=1;
            }
            Console.WriteLine("\nFor");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Howdy Doody {students[i]}");
            }
            Console.WriteLine("\nFor each");
            foreach (string j in students)
            {
                Console.WriteLine($"Ello {j}");
            }
            Console.WriteLine("\nDo while");
            num = 0;
            do
            {
                Console.WriteLine($"Greetings {students[num]}");
                num++;
            } while (num!=students.Length);
            Console.ReadLine();*/

            Random rng = new Random();
            int n = rng.Next(1,49);
            int m = rng.Next(50, 100);
            Console.WriteLine($"{n}, {m}");
            int[] numbers=new int[m-n+1];
            int t = 0;
            for (int i = n; i < m+1; i++)
            {
                numbers[t] = i;
                Console.WriteLine($"{i} is the root of {i * i}, ");
                t++;
            }
            foreach (var j in numbers)
            {
                Console.Write("{0} ",j);
            }
            Console.WriteLine("\n");
            /*int[] nums = new int[5]; 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Write a number");
                nums[0] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int mult = 1;
            foreach (var q in nums)
            {
                sum += q;
                mult = mult * q;
            }
            Console.WriteLine($"The sum is {sum}, the average is {sum / 5}, the multiplication is {mult}");*/

            do
            {
                Console.WriteLine("Buy my damn elephant");
            } while (Console.ReadLine()!="elephant");
            Console.WriteLine("Thank you\n");

            int compNum = rng.Next(1, 25);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Guess the number that the computer generates between 1-25, but be careful you only have {i} tries!");
                if (int.Parse(Console.ReadLine())==compNum)
                {
                    Console.WriteLine("You WIN!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again, we know You can do it.");
                }
            }
            Console.ReadKey();

            //int 
            //for (int i = 0; i < 4; i++)
            //{

            //}


            //Console.ReadLine();
        }
    }
}
