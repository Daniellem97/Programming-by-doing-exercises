using System;

namespace _25._Age_what_can_you_do
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Hey, whats your name?");
            name = Console.ReadLine();
            Console.WriteLine("what age are you, {0}", name);
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("you are {0}", age);
            if (age < 16)
                Console.WriteLine("you cant drive, {0}", name);
            if (age >= 16 && age <=17)
                Console.WriteLine("you can drive but not vote, {0}", name);
            if (age >=18 && age <=24)
                Console.WriteLine("you can drink but you cant rent a car, {0}", name);
            if (age >= 25)
                Console.WriteLine("you can do pretty much anything, {0}", name);

         
        }
    }
}
