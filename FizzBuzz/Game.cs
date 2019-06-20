using System;

namespace FizzBuzz
{
    class Game
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to FizzBuzz \nType any number to start...\n");
            int.TryParse(Console.ReadLine(), out int theNumber);
            //TODO INPUT VALIDATION
            for (int i = 1; i < theNumber + 1; i++)
            {
                String output = "";
                bool isFizz = i % 3 == 0;
                bool isBuzz = i % 5 == 0;

                if (isFizz)
                {
                    output += "Fizz";
                }
                if (isBuzz)
                {
                    output += "Buzz";
                }
                if (output == "")
                {
                    output += i;
                }

                Console.WriteLine(output);
            }

        }
    }
}
