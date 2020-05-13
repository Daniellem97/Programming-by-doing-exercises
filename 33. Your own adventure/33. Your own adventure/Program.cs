using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            bool repeat = true;

            //ROOM 1 START ROOM
            Console.WriteLine("You are in a creepy house! Would you like to go \"upstairs\" or into the \"kitchen\"");
            answer = Console.ReadLine();

            //ROOM 2 (LEFT TREE)
            if (answer == "upstairs")
            {
                while (repeat == true)
                {
                    Console.WriteLine("\nUpstairs you see a hallway. \nAt the end of the hallway is the master \"bedroom\". \nThere is also a \"bathroom\" off the hallway.");
                    Console.WriteLine("where would you like to go?\n");
                    answer = Console.ReadLine();

                    //ROOM 4
                    if (answer == "bedroom")
                    {
                        while (repeat == true)
                        {
                            Console.WriteLine("You are in a plush bedroom, with expensive-looking hardwood furniture. \nThe bed is unmade. In the back of the room, the closet door is ajar. \nWould you like to open the door? (\"yes\" or \"no\")");
                            answer = Console.ReadLine();

                            if (answer == "yes") //ENDING 1
                            {
                                Console.WriteLine("When you start to open the door, a pungent stench hits your nose \nbefore a rotting corpse bursts it's way out onto the floor. \nYou scream, it's your father.");
                                Console.WriteLine("\n--- BAD ENDING ---");
                                repeat = false;
                            }
                            else if (answer == "no") //ENDING 2
                            {
                                Console.WriteLine("You feel tired, you seek comfort in the messy bed. \nYou smell something odd, but you ignore it and fall asleep.");
                                Console.WriteLine("\n--- NEUTRAL ENDING ---");
                                repeat = false;
                            }
                            else //INCORRECT, SEND BACK TO QUESTION
                            {
                                Console.WriteLine("\n--- " + answer + " will not work, try doing something else ---");
                            }
                        }
                    }
                    //ROOM 5
                    else if (answer == "bathroom")
                    {
                        Console.WriteLine("You are in your bathroom which has a bathtub and your body shower gel. \nWould you like to have bath after a hectic day at work? \"yes\" or \"no\"");
                        answer = Console.ReadLine();
                        if (answer == "yes") //ENDING 3
                        {
                            Console.WriteLine("While, getting into the bath, you slip on the wet ceramic tiles. \nYou crack your head off the sink and fall to the ground, shortly before \nlying in a pool of your own blood unconcious. You bleed out");
                            Console.WriteLine("\n--- BAD ENDING ---");
                            repeat = false;
                        }
                        else if (answer == "no") //ENDING 4
                        {
                            Console.WriteLine("You stare indecisively at the showergel, sniff your armpit and leave the bathroom.");
                            Console.WriteLine("\n--- NEUTRAL ENDING ---");
                            repeat = false;
                        }
                        else //INCORRECT, SEND BACK TO QUESTION
                        {
                            Console.WriteLine("\n--- " + answer + " will not work, try doing something else ---");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n--- There is no " + answer + ", try doing something else ---");
                    }
                }
            }
            //ROOM 3 (RIGHT TREE)
            else if (answer == "kitchen")
            {
                while (repeat == true)
                {
                    Console.WriteLine("\nThere is a long countertop with dirty dishes everywhere. \nOff to one side there is, as you'd expect, a refrigerator. \nYou may open the \"refrigerator\" or look in a \"cabinet\"");
                    answer = Console.ReadLine();
                    // ROOM 6
                    if (answer == "refrigerator")
                    {
                        while (repeat == true) {

                        
                            Console.WriteLine("\nInside the refrigerator you see food and stuff. It looks pretty nasty. \nWould you like to eat some of the food? \"yes\" or \"no\"");
                            answer = Console.ReadLine();

                            if (answer == "yes")//ENDING 5
                            {
                                Console.WriteLine("you die of food poisoning. try again");
                                Console.WriteLine("\n--- BAD ENDING ---");
                                repeat = false;
                            }
                            else if (answer == "no")//ENDING 6
                            {
                                Console.WriteLine("you live another day");
                                repeat = false;
                            }
                            else //INCORRECT, SEND BACK TO QUESTION
                            {
                                Console.WriteLine("\n--- " + answer + " will not work, try doing something else ---");
                            }
                        }
                    }
                    // ROOM 7 
                    else if (answer == "cabinet")
                    {
                        while (repeat == true)
                        {
                            Console.WriteLine("\nyou're feeling a bit unwell and spot some medicine in the cabinet, do you take the medicine? \"yes\" or \"no\" ");
                            answer = Console.ReadLine();

                            if (answer == "yes")//ENDING 7
                            {
                                Console.WriteLine("The medicine is poision and you die");
                                Console.WriteLine("\n--- BAD ENDING ---");
                                
                            }
                            else if (answer == "no")//ENDING 8
                            {
                                Console.WriteLine("you soon feel better by yourself ");
                                repeat = false;
                            }
                            else //INCORRECT, SEND BACK TO QUESTION
                            {
                                Console.WriteLine("\n--- " + answer + " will not work, try doing something else ---");
                            }

                        }
                         
                    }
                    else //INCORRECT, SEND BACK TO QUESTION
                    {
                        Console.WriteLine("\n--- " + answer + " will not work, try doing something else ---");
                    }

                }


            }
            
        }
    }
}
