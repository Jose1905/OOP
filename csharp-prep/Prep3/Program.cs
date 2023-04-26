using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,11);
        int input_number;
        int tries = 0;
        Console.WriteLine($"The magic number is {magic_number}");

        do
        {
            Console.WriteLine("What is your guess? ");
            input_number = Convert.ToInt32(Console.ReadLine());
            if (input_number > magic_number)
            {
                Console.WriteLine("Lower");
            } 
            else if (input_number < magic_number)
            {
                Console.WriteLine("Higher");
            }
            tries ++;
        } while (input_number != magic_number);

        Console.WriteLine($"You got it right in {tries} tries!");
    }
}