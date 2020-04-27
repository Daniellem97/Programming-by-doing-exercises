using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("how year were you born?");
            int DOB = int.Parse(Console.ReadLine());
            int age = (2020 - DOB);
            Console.WriteLine("ok {0}, you are {1} and", name, age);
            if (age < 16)
                Console.WriteLine("you can't drive.");
            if (age < 18)
                Console.WriteLine("you can't drink.");
            if (age >= 18)
                Console.WriteLine("you can do anything that's legal.");
        }
    }
}
