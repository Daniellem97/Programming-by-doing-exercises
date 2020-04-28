using System;

namespace _23._Else_and_If
{
    class Program
    {
        static void Main(string[] args)
        {
			int people = 30;
			int cars = 40;
			int buses = 15;

			if (cars > people)
			{
				Console.WriteLine("We should take the cars.");
			}
			else if (cars < people)
			{
				Console.WriteLine("We should not take the cars.");
			}
			else
			{
				Console.WriteLine("We can't decide.");
			}


			if (buses > cars)
			{
				Console.WriteLine("That's too many buses.");
			}
			else if (buses < cars)
			{
				Console.WriteLine("Maybe we could take the buses.");
			}
			else
			{
				Console.WriteLine("We still can't decide.");
			}


			if (people > buses)
			{
				Console.WriteLine("All right, let's just take the buses.");
			}
			else
			{
				Console.WriteLine("Fine, let's stay home then.");
			}

		}
	}
}
