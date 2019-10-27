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

        private static object PromptOptions;
        /

            var prompter = new ConsolePrompt(null);
            var validOperations = new[] { "x", "/", "+", "-" };
            var firstNum prompter.Prompt<int>("enter the first number in your basic equation", PromptOptions.Required);
            var secondNum = prompter.Prompt<int>("Now enter your second number in the basic equation", PromptOptions.Required);
            var operation = prompter.Prompt<string>("Ok now enter your operation (" + string.Join(", ", validOperations) + ")", PromptOptions.Required, validationMethod: x => validOperations.Contains(x));


        // Cerate your exercise methods her

    }

}

   