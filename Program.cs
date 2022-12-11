using System;
using System.Linq;

namespace BackEnd_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Value.GetValue();
        }
    }

    static public class Calculator
    {
        static public void Sum(double x, double y)
        {
            var result = x + y;
            Value.ShowResult(result);
        }
        static public void Subtrack(double x, double y)
        {
            var result = x - y;
            Value.ShowResult(result);
        }
        static public void Multiply(double x, double y)
        {
            var result = x * y;
            Value.ShowResult(result);
        }
        static public void Divide(double x, double y)
        {
            var result = x / y;
            Value.ShowResult(result);
        }
    }

    static public class Value
    {
        static public void GetValue()
        {
            do
            {
                double num1, num2;
                string opr;
                // bool runAgain;
                Console.WriteLine("--------------");
                Console.WriteLine("Calculator App");
                Console.WriteLine("--------------");
                Console.WriteLine("Enter Number 1:");


                try
                {
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Number 2:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Operators:");
                    Console.WriteLine("+:   Sum");
                    Console.WriteLine("-:   Subtrack");
                    Console.WriteLine("*:   Multiply");
                    Console.WriteLine("/:   Divide");
                    Console.WriteLine("Enter An Operator:");
                    opr = Console.ReadLine();

                    if (num2 == 0 && opr == "/")
                    {
                        Console.WriteLine("Divition By Zero!");
                        RunAgain();
                    }
                    SetOperator(num1, num2, opr);
                }
                catch (FormatException)
                {
                    Console.WriteLine("That Was Not A Valid Value");
                    RunAgain();
                }


            } while (true);
        }

        static void SetOperator(double a, double b, string c)
        {
            switch (c)
            {
                case "+":
                    Calculator.Sum(a, b);
                    break;
                case "-":
                    Calculator.Subtrack(a, b);
                    break;
                case "*":
                    Calculator.Multiply(a, b);
                    break;
                case "/":
                    Calculator.Divide(a, b);
                    break;
                default:
                    Console.WriteLine("That Was Invalid Operator!");
                    RunAgain();
                    break;
            }
        }

        static public void ShowResult(double result)
        {
            Console.WriteLine($"Your Result: {result}");
            RunAgain();
        }

        static public void RunAgain()
        {
            Console.WriteLine("Would You Like To Continue (Y = Yes, N = No)");
            var respone = Console.ReadLine();
            if (respone == "Y" || respone == "y")
            {
                Console.Clear();
                GetValue();
            }
            else if (respone == "N" || respone == "n")
            {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That Was Not Correct!");
                RunAgain();
            }
        }
    }
}
