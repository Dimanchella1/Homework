using System;

class Program
{
    static void Main()
    {
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
    }
}
