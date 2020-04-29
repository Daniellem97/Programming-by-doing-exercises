using System;

namespace _24._Weekday_name
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekday1, weekday2, weekday3, weekday4, weekday5, weekday6, weekday7;
            int answer;
            weekday1 = "Monday";
            weekday2 = "Tuesday";
            weekday3 = "Wednesday";
            weekday4 = "Thursday";
            weekday5 = "Friday";
            weekday6 = "Saturday";
            weekday7 = "Sunday";

            Console.WriteLine("what day of the week is it? answer in format 1,2,3 etc");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
                Console.WriteLine(weekday1);
            else if (answer == 2)
                Console.WriteLine(weekday2);
            else if (answer == 3)
                Console.WriteLine(weekday3);
            else if (answer == 4)
                Console.WriteLine(weekday4);
            else if (answer == 5)
                Console.WriteLine(weekday5);
            else if (answer == 6)
                Console.WriteLine(weekday6);
            else if (answer == 7)
                Console.WriteLine(weekday7);
        
            else
                Console.WriteLine("error");
        
        }
    }
}
