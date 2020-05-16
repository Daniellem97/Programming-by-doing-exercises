using System;

namespace _35._Two_more_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1, answer2;
            Console.WriteLine("TWO MORE QUESTIONS BABY");
            Console.WriteLine("\n Thank of something and ill try to guess it!");
            Console.WriteLine("\n Question 1) Does it stay inside or outside or both?");
            answer1 = Console.ReadLine();
            Console.WriteLine("Question 2) Is it a living thing? yes or no");
            answer2 = Console.ReadLine();

            if (answer1 == "inside" && answer2 == "yes")
            {
                Console.WriteLine("Obviously the only living inside thing on your mind is a houseplant");
            }
            if (answer1 == "inside" && answer2 == "no")
            {
                Console.WriteLine("obviously the only non living inside thing on your mind is a shower curtain");
            }
            if (answer1 == "outside" && answer2 == "yes")
            {
                Console.WriteLine("obviously the only living outside thing on your mind is a bison");
            }
            if (answer1 == "outside" && answer2 == "no")
            {
                Console.WriteLine("obviously the only non living thing on your mind is a billboard");
            }
            if (answer1 == "both" && answer2 == "yes")
            {
                Console.WriteLine("obviously the only living, inside/outside thing on your mind is a dog");
            }
            if (answer1 == "both" && answer2 == "no")
            {
                Console.WriteLine("obviously the only non living, inside/outside thing on your mind is a cellphone");
            }
        }
    }
}
