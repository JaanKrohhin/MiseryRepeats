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
            Console.ReadLine();
            Console.WriteLine("\n");
        }
    }
}
