using System;

namespace _18._Age_in_five_years
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, beforeage, afterage;

            Console.WriteLine("Hello. What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi {0}! How old are you?",name);
            age = int.Parse(Console.ReadLine());
            beforeage = (age - 5);
            afterage = (age + 5);
            Console.WriteLine("did you know that in five years you will be {0} years old? and five years ago you were {1}! imagine that!", afterage, beforeage);

        }
    }
}
