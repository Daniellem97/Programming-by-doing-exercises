using System;

namespace _27._A_Little_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            string answer1, answer2, answer3, melbounre, anchorage, juneau, yes, no, five, eleven, fifteendiv;

            counter = 0;
            five = "five";
            eleven = "eleven";
            fifteendiv = "fifteen/three";
            yes = "yes";
            no = "no";
            juneau = "Juneau";
            anchorage = "Anchorage";
            melbounre = "Melbourne";
            
            Console.WriteLine("please press any key to start the quiz");
            Console.ReadLine();
            Console.WriteLine( "                     ");
            Console.WriteLine(" Q1. What is the capital of Alaska?");
            Console.WriteLine(melbounre);
            Console.WriteLine(juneau);
            Console.WriteLine(anchorage);
            answer1 = Console.ReadLine();

            if (answer1 == juneau)
                Console.WriteLine("thats correct, " + (++counter) + "point");
            else
                Console.WriteLine( "Juneau is the capital of Alska");

            Console.WriteLine(" Q2. Can you store the value 'cat' in a variable of type int");
                Console.WriteLine(yes);
                Console.WriteLine(no);
                answer2 = Console.ReadLine();

            if (answer2 == yes )
                Console.WriteLine("thats correct, " + (++counter) + "point");
            else
                Console.WriteLine(" sorry, 'cat' is a string. ints can only store numbers");

            Console.WriteLine(" Q2. What is the result of 9+6/3");
            Console.WriteLine(five);
            Console.WriteLine(eleven);
            Console.WriteLine(fifteendiv);
            answer3 = Console.ReadLine();

            if (answer3 == eleven)
                 Console.WriteLine("Thats corecct, " + (++counter) + "point");
            else
                Console.WriteLine("the answer was eleven");

            Console.WriteLine("overall you got " + counter + " out of 3");



            
        }
    }
}
