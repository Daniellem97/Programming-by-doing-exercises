using System;

namespace _34._Age_message_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Hello what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hey {0}, what age are you?", name);
            age = int.Parse(Console.ReadLine());

            if (age < 16)
            {
                Console.WriteLine("you're {0}, that means you cant drive ,{1}", age, name);
            }
            if (age >= 16 && age <= 17)
            {
                Console.WriteLine("you're {0}, that means you can drive but not vote ,{1}", age, name);
            }
            if (age >= 18 && age <= 24)
            {
                Console.WriteLine("you're {0}, that means you can vote but not rent a car ,{1}", age, name);
            }
            if (age >= 25)
            {
                Console.WriteLine("you're {0}, that means you can pretty much do anything ,{1}", age, name);
            }
        }
    }
}
