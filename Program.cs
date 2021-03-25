using System;

/*
Write a program that accepts a number from the user and reports the square root of that number.
Handle the situations where the user enters either a non-number or a negative number.
Explore the BackgroundColor and ForegroundColor properties of the Console class.  
Use these properties to give your program some character.
 */

namespace Exercise_1
{
    class Program
    {
        static int Main(string[] args) {
            bool carryOn = true;
            // Get an array with the values of ConsoleColor enumeration members.
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.WriteLine(colors.Length);
            string input;
            int i = 0;
            while (carryOn) {
                Console.Write("Enter a number to calculate its square root: ");
                input = Console.ReadLine();
                if (input == "Q") return 0;
                else if (double.TryParse(input, out double square_root)) {
                    Console.BackgroundColor = colors[(i++) % 16];
                    Console.ForegroundColor = colors[i % 16];
                    Console.WriteLine(Math.Sqrt(square_root));
                } else {
                    for (int j = 0; j < 100; j++) {
                        Console.BackgroundColor = colors[(i++) % 16];
                        Console.ForegroundColor = colors[i % 16];
                        Console.WriteLine("THAT'S NOT A NUMBER!!!!!!!!!!");
                    }
                }
            }
            return 0;
        }
    }
}
