using System;

namespace _8._Numbers_and_Maths
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("I will now count my chickens:");

			Console.WriteLine("Hens " + (25 + 30 / 6));
			Console.WriteLine("Roosters " + (100 - 25 * 3 % 4));

			Console.WriteLine("Now I will count the eggs:");

			Console.WriteLine(3 + 2 + 1 - 5 + 4 % 2 - 1 / 4 + 6);

			Console.WriteLine("Is it true that 3 + 2 < 5 - 7?");

			Console.WriteLine(3 + 2 < 5 - 7);

			Console.WriteLine("What is 3 + 2? " + (3 + 2));
			Console.WriteLine("What is 5 - 7? " + (5 - 7));

			Console.WriteLine("Oh, that's why it's false.");

			Console.WriteLine("How about some more.");

			Console.WriteLine("Is it greater? " + (5 > -2));
			Console.WriteLine("Is it greater or equal? " + (5 >= -2));
			Console.WriteLine("Is it less or equal? " + (5 <= -2));
		}
    }
}
