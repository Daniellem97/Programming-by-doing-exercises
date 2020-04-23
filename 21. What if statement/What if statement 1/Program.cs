using System;

namespace What_if_statement_1
{
    class Program
    {
        static void Main(string[] args)
       
			{
				int people = 20;
				int cats = 30;
				int dogs = 15;

				if (people < cats)
				{
					Console.WriteLine("Too many cats!  The world is doomed!");
				}

				if (people > cats)
				{
					Console.WriteLine("Not many cats!  The world is saved!");
				}

				if (people < dogs)
				{
					Console.WriteLine("The world is drooled on!");
				}

				if (people > dogs)
				{
					Console.WriteLine( "The world is dry!");
				}

				if (people >= dogs)
				{
					Console.WriteLine("People are greater than or equal to dogs.");
				}

				if (people <= dogs)
				{
					Console.WriteLine("People are less than or equal to dogs.");
				}

				if (people == dogs)
				{
					Console.WriteLine("People are dogs.");
				}
			}
    }
}
