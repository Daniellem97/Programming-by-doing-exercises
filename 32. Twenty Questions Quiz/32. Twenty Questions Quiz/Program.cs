using System;

namespace _32._Twenty_Questions_Quiz
{
    class Program
    {
        static void Main(string[] args)
            
        {
            string animal, vegetable, mineral, yes, no, answer1, answer2;


            animal = "animal";
            vegetable = "vegetable";
            mineral = "mineral";
            yes = "yes";
            no = "no";
            
            Console.WriteLine("Two Questions!");
            Console.WriteLine("Think of an object, and i'll try to guess it");
            Console.WriteLine("  ");
            Console.WriteLine("Question 1) Is it an animal, vefetable or mineral");
            answer1 = Console.ReadLine();
            Console.WriteLine("Question2) Is it bigger than a breadbox?");
            answer2 = Console.ReadLine();

            if (answer1 == animal && answer2 == yes)
                Console.WriteLine("My guess is that you are thinking of a moose");
           else if (answer1 == animal && answer2 == no)
                Console.WriteLine("My guess is that you are thinking of a squirrel"); 
           else if (answer1 == vegetable && answer2 == yes)
                Console.WriteLine("My guess is that you are thinking of a watermelon");
           else if (answer1 == vegetable && answer2 == no)
                Console.WriteLine("My guess is that you are thinking of a carrot");
           else if (answer1 == mineral && answer2 == yes)
                Console.WriteLine("My guess is that you are thinking of a camaro");
           else if (answer1 == mineral && answer2 == no)
                Console.WriteLine("My guess is that you are thinking of a paper clip");

            Console.WriteLine("I would ask if im right but i dont actually care");
            

        }
    }
}
