using System;

namespace _13._Your_Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1, course2, course3, course4, course5, course6, teacher1, teacher2, teacher3, teacher4, teacher5, teacher6;

            course1 = "maths";
            course2 = "english";
            course3 = "irish";
            course4 = "geography";
            course5 = "histroy";
            course6 = "french";

            teacher1 = "Mr Murphy";
            teacher2 = "Ms Burke";
            teacher3 = "Mr Maguire";
            teacher4 = "Ms Byrne";
            teacher5 = "Mr Gargan";
            teacher6 = "Mr Wallace";


            Console.WriteLine("+------------------------+");
            Console.WriteLine("| " + course1 + " | " + teacher1 + " |");
            Console.WriteLine("| " + course2 + " | " + teacher2 + " |");
            Console.WriteLine("| " + course3 + " | " + teacher3 + " |");
            Console.WriteLine("| " + course4 + " | " + teacher4 + " |");
            Console.WriteLine("| " + course5 + " | " + teacher5 + " |");
            Console.WriteLine("| " + course6 + " | " + teacher6 + " |");
            Console.WriteLine("+------------------------+");
        }
        
    }
}
