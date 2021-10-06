using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingMisery
{
    class OpeningClass
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("how are ya kid");
            string name = Console.ReadLine();
            Console.WriteLine(name + ", Howdy doody");
            if (name.ToLower()=="jaan")
            {
                Console.WriteLine("i am a killer, i am ze terminator\n");
                Console.WriteLine("I wanna go to the cinema, lets get tickets! How old are you?");
                int age = int.Parse(Console.ReadLine());
                if (119 < age || age < 0)
                {
                    Console.WriteLine("error, mah dude");
                }
                else if (age<6)
                {
                    Console.WriteLine("Free tickets pog");
                }
                else if (5 < age && age < 15)
                {
                    Console.WriteLine("Cheap, tickets pog");
                }
                else if (age>14 && age<66)
                {
                    Console.WriteLine("Normal priced tickets, damn");
                }else if (age > 65)
                {
                    Console.WriteLine("Senior discount POGGERS");
                }
            }
            else
            {
                Console.WriteLine("i am just a program");
            }


            Console.WriteLine("\nGimme a number");
            int num1 = int.Parse( Console.ReadLine());//Convert.toInt32()
            Console.WriteLine("Gimme a second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} times {num2} equals: {num1 * num2} ");*/
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("HEY, you! Random student #1, what is your name?");
            string name1 = Console.ReadLine();
            Console.WriteLine("HEY, you! Random student #2, what is your name?");
            string name2 = Console.ReadLine();
            if ((name1.ToLower()=="nikita" && name2.ToLower()== "jaan") || (name1.ToLower()== "jaan" && name2.ToLower() == "nikita")) 
            {
                Console.WriteLine("You are neighbors today, NOICE");
            }
            else 
            {
                Console.WriteLine("Nothing, absolutely nothing");
            }
            Console.WriteLine("\nwhat is the lenght and width of this wall in cm?");
            double wall1 = Math.Abs(double.Parse(Console.ReadLine()))/100;//Convert.toInt32()
            double wall2 = Math.Abs(double.Parse(Console.ReadLine()))/100;//Convert.toInt32()
            Console.WriteLine($"The square area of this wall is {wall1*wall2}m2\ndo you wanna do renovations? y/n");
            string choice = Console.ReadLine();
            if (choice=="y")
            {
                Console.WriteLine("How many euros per square meter you want?");
                Console.WriteLine(double.Parse(Console.ReadLine())*(wall1* wall2));

            }
            else if (choice == "n")
            {
                Console.WriteLine("okay");
            }


            Console.WriteLine("\ngimme some price of a thing");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine($"You get a 30% discount and the price becomes {price-price*0.3}");



            Console.WriteLine("\nwhat is temperature in this room?");
            double temp = double.Parse(Console.ReadLine());//Convert.toInt32()
            if (temp>18)
            {
                Console.WriteLine("Great tempterature for winter");
            }
            else
            {
                Console.WriteLine("We need to turn on the heater");
            }






            Console.WriteLine("\nwhat is your height in centimeters");
            int height = int.Parse(Console.ReadLine());
            if (height<50 && height>300)
            {
                Console.WriteLine("errrrrrrorrrr");
            }
            else if (height < 100 && height > 49)
            {
                Console.WriteLine("you are small");
            }
            else if (height < 200 && height > 99)
            {
                Console.WriteLine("you are average");
            }
            else
            {
                Console.WriteLine("you are TALLLLL");
                
            }






            Console.WriteLine("\nwhat is your gender and what isyour height in centimeters");
            string gender = Console.ReadLine();
            int height2 = int.Parse(Console.ReadLine());
            if (gender.ToLower()=="male")
            {
                Console.WriteLine("so you are a dude");
            }
            else if (gender.ToLower()=="female")
            {
                Console.WriteLine("so you are a woman");
            }
            else
            {
                Console.WriteLine("idk what gender that is but it is cool");
            }


            if (height2 < 50 && height2 > 300)
            {
                Console.WriteLine("errrrrrrorrrr");
            }
            else if (height2 < 100 && height2 > 49)
            {
                Console.WriteLine("you are small");
            }
            else if (height2 < 200 && height2 > 99)
            {
                Console.WriteLine("you are average");
            }
            else
            {
                Console.WriteLine("you are TALLLLL");

            }
            Console.WriteLine("\ndo you want to buy milk,bread,donuts?");
            string choice2 = Console.ReadLine();
            if (choice == "y")
            {
                Console.WriteLine("The sum of those products is 3€");
            }
            else if (choice == "n")
            {
                Console.WriteLine("Cool, cool");
            }


            Console.ReadLine();
        }
    }
}
