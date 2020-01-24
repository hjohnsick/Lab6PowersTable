using System;

namespace Lab6PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            char userInput = 'y';

            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine("");

            while (userInput == 'y')
            {
                
                Console.WriteLine("");
                Console.Write("Enter an integer: ");
                int baseNumber = int.Parse(Console.ReadLine());

                //printing the base number the user entered to the 2nd power?
                

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
                        Console.WriteLine("OKBAI!!");
                    }
                }

            }
        }
        public static void DisplayTable(int input)
        {
            
            Console.WriteLine("\n");
            Console.WriteLine("Number\tSquared\tCubed");
            Console.WriteLine("======\t======\t======");

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(Power(i) + "  " + Power2(i) + "   " + Power3(i));

            }
        }

        public static int Power(int baseNumber)
        {
            return baseNumber;

        }
        public static int Power2(int baseNumber)
        {
            return baseNumber * baseNumber;

        }

        public static int Power3(int baseNumber)
        {
            return Power2(baseNumber)*baseNumber;
        }
    }

}
