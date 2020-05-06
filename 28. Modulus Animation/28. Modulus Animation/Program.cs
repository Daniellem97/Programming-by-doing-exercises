using System;
using System.Threading;

namespace _28._Modulus_Animation
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 100000000; i++)
			{
				if (i % 16 == 0)
					Console.WriteLine(" **************************************************                 \r");
				else if (i % 16 == 1)
					Console.WriteLine("   **************************************************               \r");
				else if (i % 16 == 2)
					Console.WriteLine("     **************************************************             \r");
				else if (i % 16 == 3)
					Console.WriteLine("       **************************************************           \r");
				else if (i % 16 == 4)
					Console.WriteLine("         **************************************************         \r");
				else if (i % 16 == 5)
					Console.WriteLine("           **************************************************       \r");
				else if (i % 16 == 6)
					Console.WriteLine("             **************************************************     \r");
				else if (i % 16 == 7)
					Console.WriteLine("               **************************************************   \r");
				else if (i % 16 == 8)
					Console.WriteLine("                 ************************************************** \r");
				else if (i % 16 == 9)
					Console.WriteLine("               **************************************************   \r");
				else if (i % 16 == 10)
					Console.WriteLine("             **************************************************     \r");
				else if (i % 16 == 11)
					Console.WriteLine("           **************************************************       \r");
				else if (i % 16 == 12)
					Console.WriteLine("         **************************************************         \r");
				else if (i % 16 == 13)
					Console.WriteLine("       **************************************************           \r");
				else if (i % 16 == 14)
					Console.WriteLine("     **************************************************             \r");
				else if (i % 16 == 15)
					Console.WriteLine("   **************************************************               \r");

				Thread.Sleep(50);
			}
		}
	}
}
    

