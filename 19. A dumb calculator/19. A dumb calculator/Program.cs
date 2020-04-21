using System;

namespace _19._A_dumb_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, answer;

            Console.WriteLine("what is your first number?");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("what is your second number?");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("what is your third number?");
            num3 = double.Parse(Console.ReadLine());

            answer = ((num1 + num2 + num3) / 2);
            Console.WriteLine(answer);
        }
    }
}
