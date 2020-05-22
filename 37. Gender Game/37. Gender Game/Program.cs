using System;

namespace _37._Gender_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, gender, answer;
            int age;

            Console.WriteLine("Hello what is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine(" ok {0}, whats your last name?", firstName);
            lastName = Console.ReadLine();
            Console.WriteLine("what age are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("your gender?");
            gender = Console.ReadLine();
            
            Console.WriteLine("\nFirst Name: {0} \n Last Name: {1} \n Age: {2} \n Gender: {3}", firstName, lastName, age, gender );

            if (age >= 20)
            {
                Console.WriteLine("are you married? yes or no");
                answer = Console.ReadLine();

                if (answer == "yes" && age <= 29 && gender == "female")
                {
                    Console.WriteLine(" I will call you mrs Sophie Turner");
                }
                if (answer == "yes" && age >= 30 && age <= 40 && gender == "female")
                {
                    Console.WriteLine("I will call you mrs kim kardasian"); 
                }

                if (answer == "yes" && age >= 41 && age <= 50 && gender == "female")
                {
                    Console.WriteLine(" I will call you mrs Eva Longoria");
                }
                if (answer == "yes" && age >= 51 && gender == "female")
                {
                    Console.WriteLine(" I will call you mrs Jennifer Aniston");
                }
                if (answer == "no" && age <= 29 && gender == "female")
                {
                    Console.WriteLine(" I will call you ms Kylie Jennar");
                }
                if (answer == "no" && age >= 30 && age <= 40 && gender == "female")
                {
                    Console.WriteLine("I will call you mrs Taylor Swift");
                }
                if (answer == "no" && age >= 41 && age <= 50 && gender == "female")
                {
                    Console.WriteLine(" I will call you mrs Shakira");
                }
                if (answer == "no" && age >= 51 && gender == "female")
                {
                    Console.WriteLine(" I will call you mrs Madonna");
                }
                if (answer == "no" && age <= 29 && gender == "male")
                {
                    Console.WriteLine(" I will call you Mr Joe Jonas");
                }
                if (answer == "yes" && age >= 30 && age <= 40 && gender == "male")
                {
                    Console.WriteLine("I will call you Mr Kanye West");
                }

                if (answer == "yes" && age >= 41 && age <= 50 && gender == "male")
                {
                    Console.WriteLine(" I will call you Mr Dwayne Johnston");
                }
                if (answer == "yes" && age >= 51 && gender == "male")
                {
                    Console.WriteLine(" I will call you Mr Robert Downey Jr");
                }
                if (answer == "no" && age <= 29 && gender == "male")
                {
                    Console.WriteLine(" I will call you Mr Taylor Launter");
                }
                if (answer == "no" && age >= 30 && age <= 40 && gender == "male")
                {
                    Console.WriteLine("I will call you Mr Ryan Gosling");
                }
                if (answer == "no" && age >= 41 && age <= 50 && gender == "male")
                {
                    Console.WriteLine(" I will call you Mr Leonardo DiCaprio");
                }
                if (answer == "no" && age >= 51 && gender == "male")
                {
                    Console.WriteLine(" I will call you Mr Keanu Reeves");
                }

                else if (age >= 20 && gender == "female")
                {
                    Console.WriteLine("I will call you Miss Noah Cyrus");
                }
                else if (age >= 20 && gender == "male")
                {
                    Console.WriteLine("I will call you Mr Finn Wolfhart");
                }
            }
                
        }
    }
}
