using System;

namespace _16._Name__Age__and_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double salary;
            Console.WriteLine("Hello , what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi,{0} ! How old are you?" , name);
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("so you're {0}, eh? Thats not old at all! How much do you make, {1}" , age, name);
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("so {0} , you're {1} and you make {2}, got it!" , name, age, salary);


        }
    }
}
