using System;

namespace Räknare
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Double FirstNum;
            Double SecoundNum;
            string operation;
            Double answer;

            
            bool keepAlive = true;

            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assigment number ( or -1 to exit )\nSelect: ");
                    int selectionNumber = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;


                    
                    switch (selectionNumber)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;

                        // Add new cases as you progress with your exercises

                        case -1:
                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a valid assigment number!");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A exception has occurred!\nIt can be that you inputed somthing other then a number in the menu or the assigment you were running has a flaw");
                }

                Console.ResetColor();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static void RunExerciseOne()
        {
            Console.WriteLine("Hello <firstname> <lastname>! I´am glad to inform you that you are the test subject of my very first assignment!");
        }

        private static void RunExerciseTwo()
        {


        }
        private static void RunExerciseThree()

        {

            var prompter = new ConsolePrompt(null);
            {
                Console.WriteLine("Enter first number:");
                string name = Console.ReadLine();

                Console.WriteLine("enter operation and last number:");
                string lastName = Console.ReadLine();

                string fullName = name + " " + lastName;
                Console.WriteLine($"Your answer is: {fullName}");

                Console.ReadKey();
            }


        }

        // Cerate your exercise methods her

    }

}

   