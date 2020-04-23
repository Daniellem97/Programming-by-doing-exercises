using System;

namespace _20._BMI_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, kg, bmi, heightSquared;

            Console.WriteLine("your height in m?");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("your weight in kg?");
            kg = double.Parse(Console.ReadLine());
            heightSquared = Math.Pow(height, 2);
            bmi = kg / heightSquared;
            Console.WriteLine("your bmi is {0}", bmi);
        }
    }
}
