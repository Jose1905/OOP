using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "";
        int number = 0;
        int squared = 0;
        
        DisplayWelcome();
        name = PromptUserName();
        number = PromptUserNumber();
        squared = SquareNumber(number);
        DisplayResult(name, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(String name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}