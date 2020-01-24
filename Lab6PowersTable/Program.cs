using System;

namespace Lab6PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput = 'y';

            //prints a header message
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine("");

            //runs while loop while user input is yes
            while (userInput == 'y')
            {
                //Gets user input and stores it as an integer into baseNumber
                Console.Write("Enter an integer: ");
                int baseNumber = int.Parse(Console.ReadLine());

                //When baseNumber is greater than 0 the table will display
                if (baseNumber > 0)
                {
                    DisplayTable(baseNumber);
                }

                userInput = ' ';
                while (userInput != 'y' && userInput != 'n')
                {
                    Console.WriteLine("\nWould you like to continue? y/n?");
                    userInput = Console.ReadLine().ToLower()[0];
                    if (userInput == 'n')
                    {
                        Console.WriteLine("Good Day!");
                    }
                }

            }
        }
        public static void DisplayTable(int input)
        {
            //my attempt at getting the table to line up
            Console.WriteLine("\n");
            Console.WriteLine("Number\tSquared\tCubed");
            Console.WriteLine("======\t======\t======");

            // calls methods for userinput, square and cube and prints to the console.
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(UserInput(i) + "      " + Square(i) + "      " + Cube(i));

            }
        }
        //method to calculate the base
        public static int UserInput(int baseNumber)
        {
            return baseNumber;

        }
        //method to calculate square
        public static int Square(int baseNumber)
        {
            return baseNumber * baseNumber;

        }
        //method to calculate cube
        public static int Cube(int baseNumber)
        {
            return Square(baseNumber)*baseNumber;
        }
    }

}
