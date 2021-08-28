using System;

namespace SwitchCaseCalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            char d;
            Console.Write("Enter first operand: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second operand: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operator: ");
            d = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Operation: ");
            switch (d)
            {
                case '+':
                    c = a + b;
                    Console.WriteLine("{0} + {1} = {2}", a, b, c);
                    break;
                case '-':
                    c = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, c);
                    break;
                case '*':
                    c = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, c);
                    break;
                case '/':
                    c = a / b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, c);
                    break;
                case '%':
                    c = a % b;
                    Console.WriteLine("{0} % {1} = {2}", a, b, c);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
