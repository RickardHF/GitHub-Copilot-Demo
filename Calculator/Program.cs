/* 
This is a console app
the app takes 3 arguments from the user
1. the operator 
2. the first number
3. the second number

based on the operator "add", "sub", "mul", "div" the app will perform the operation on the two numbers
the result gets output to the console
*/

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: Calculator <operator> <number1> <number2>");
                return;
            }

            string op = args[0];
            double num1 = double.Parse(args[1]);
            double num2 = double.Parse(args[2]);

            double result = 0;
            switch (op)
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "sub":
                    result = num1 - num2;
                    break;
                case "mul":
                    result = num1 * num2;
                    break;
                case "div":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}