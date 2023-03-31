using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
               

            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("/*enter num1:*/");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter num2:");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("enter an option");
                Console.WriteLine("+ : Add");
                Console.WriteLine(" - : Substract");
                Console.WriteLine(" * : Multiply");
                

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("your result is {num1} + {num2} :" + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("your result is {num1} - {num2} :" + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("your result is {num1} * {num2} :" + result);
                        break;

                }
                Console.WriteLine("would you like to continue (esc = yes, alt = no):");
            } while (Console.ReadLine().ToUpper() == "esc");

            
            Console.ReadKey();




















            }
    }
}
