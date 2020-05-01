using System;

namespace _26._Space_Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            string Venus, Mars, Jupiter, Saturn, Uranus, Neptune, answer;

            Console.WriteLine("Please enter your current earth weight ");
            weight = double.Parse(Console.ReadLine());

            Venus = "Venus";
            Jupiter = "Jupiter";
            Mars = "Mars";
            Saturn = "Saturn";
            Uranus = "Uranus";
            Neptune = "Neptune";

            Console.WriteLine("I have information on the following plants");
            Console.WriteLine(Venus  + "   " +   Jupiter  + "   " + Mars );
            Console.WriteLine( Saturn + "    " + Uranus + "   " + Neptune );
            Console.WriteLine("Which planet are you visiting?");
            answer = Console.ReadLine();
            if (answer == Venus)
                Console.WriteLine(" your weight would be " + (weight * 0.78) + " on " + answer);
          else  if (answer == Mars)
                Console.WriteLine(" your weight would be " + (weight * 0.39) +" on " + answer);
          else  if (answer == Jupiter)
                Console.WriteLine(" your weight would be " + (weight * 2.65) + " on " + answer);
           else if (answer == Saturn)
                Console.WriteLine(" your weight would be " + (weight * 1.17) + " on " + answer);
           else if (answer == Uranus)
                Console.WriteLine(" your weight would be " + (weight * 1.05) + " on " + answer);
           else if (answer == Neptune)
                Console.WriteLine(" your weight would be " + (weight * 1.23) + " pounds on " + answer);
            else
                Console.WriteLine("im not too sure sorry");
        }
    }
}
