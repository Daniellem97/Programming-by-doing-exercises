using System;

namespace _17._More_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, userLogin;
            int age;
            double studentID, GPA;

            Console.WriteLine("Hello whats your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("whats your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("what age are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("what is your student ID?");
            studentID = double.Parse(Console.ReadLine());
            Console.WriteLine("what is your user login?");
            userLogin = Console.ReadLine();
            Console.WriteLine("what is your gpa 0.0-4.0?");
            GPA = double.Parse(Console.ReadLine());

            Console.WriteLine("Login: {0}" , userLogin);
            Console.WriteLine("ID: {0}", studentID);
            Console.WriteLine("Name: {0}, {1}", lastName, firstName);
            Console.WriteLine("GPA: {0}", GPA);
            Console.WriteLine("Age: {0}", age);
        }
    }
}
