using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatingMisery
{
    class SubProgram
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(multiplication(5, 7));
            Console.WriteLine((a,b, multiplication(a, b)));
            Console.WriteLine(average(a, b));

            calc(a, b, c);
            Console.ReadKey();
        }
        static int multiplication(int a, int b)
        {
            return a * b;
        }
        static int average(int a, int b)
        {
            return (a + b) / 2;
        }
        static void calc(int a, double b, char c)
        {
            string nurr = "nurr ";
            for (int i = 0; i < Eval(a.ToString() + c + b.ToString()); i++)
            {
                Console.Write(nurr);
            }
        }
        public static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }    
    }
}
