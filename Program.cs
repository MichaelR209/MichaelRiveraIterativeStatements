using System;

namespace MichaelRiveraIterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your current amount of 'Use Tokens' (1-10)");
            {
                
                string input = Console.ReadLine();

                int value_of_input = int.Parse(input);
                Int32 value = 10, i = value_of_input;

                while (i < value)
                {
                    Console.WriteLine("Executing While loop, this will continue until you reach maximum amount of credits (10)");
                    i = i + 1;
                    Console.WriteLine("You are now at " + i);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
