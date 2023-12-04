using System;

class Program
{
    static void Main()
    {
        // Exercise 1:
        Console.WriteLine("Write a number: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number % 7 == 0)
            {
                if (number % 23 == 0)
                {
                    Console.WriteLine("The number is a multiple of both 7 and 23");
                }
                else
                {
                    Console.WriteLine("The number is a multiple of 7, but not 23");
                }
            }
            else
            {
                Console.WriteLine("The number is not a multiple of 7");
            }
        }
        else
        {
            Console.WriteLine("An incorrect number was entered");
        }

        // Divider between exercises
        Console.WriteLine("\n--- End of Exercise 1 ---\n");

        // Exercise 2:
        Console.WriteLine("Enter X coordinate:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Y coordinate:");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == 0 || y == 0)
        {
            Console.WriteLine("None of the coordinates should be 0");
        }
        else
        {
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("The point is in the first coordinate quadrant");
                }
                else
                {
                    Console.WriteLine("The point is located in the fourth coordinate quadrant");
                }
            }
            else // x < 0
            {
                if (y > 0)
                {
                    Console.WriteLine("The point is in the second coordinate quadrant");
                }
                else
                {
                    Console.WriteLine("The point is in the third coordinate quadrant");
                }
            }
        }

        // Divider between exercises
        Console.WriteLine("\n--- End of Exercise 2 ---\n");

        // Exercise 3
        Console.WriteLine("Write a number from 10 to 99:");
        int number3 = Convert.ToInt32(Console.ReadLine());

        if (number3 < 10 || number3 > 99)
        {
            Console.WriteLine("The number is not in the range of 10 to 99");
        }
        else
        {
            int firstDigit = number3 / 10;
            int secondDigit = number3 % 10;

            if (firstDigit > secondDigit)
            {
                Console.WriteLine("Max number: " + firstDigit);
            }
            else
            {
                Console.WriteLine("Max number: " + secondDigit);
            }
        }

        // Divider between exercises
        Console.WriteLine("\n--- End of Exercise 3 ---\n");

        // Exercise 4
        Console.WriteLine("Enter a natural number N:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number4) && number4 > 0)
        {
            string numberString = number4.ToString();

            for (int i = 0; i < numberString.Length; i++)
            {
                Console.Write(numberString[i]);

                if (i < numberString.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The entered number is not a natural number. Please try again.");
        }

        // Divider between exercises
        Console.WriteLine("\n--- End of Exercise 4 ---\n");
    }
}
