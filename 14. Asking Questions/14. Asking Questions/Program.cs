using System;

namespace _14._Asking_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
			int age;
			String height;
			double weight;

			Console.WriteLine("How old are you? ");
			age = int.Parse(Console.ReadLine());

			Console.WriteLine("How tall are you? ");
			height = Console.ReadLine();

			Console.WriteLine("How much do you weigh in kgs? ");
			weight = double.Parse(Console.ReadLine());

			Console.WriteLine("So you're " + age + " years old, " + height + " tall and " + weight + "kgs heavy.");
		}
    }
}
