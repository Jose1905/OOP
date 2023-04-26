using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter;
        string sign = "";
        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else 
        {
            Console.WriteLine("Don't give up! You'll do it better next semester :D");
        }

        if (grade < 97 && grade >= 60)
        {
            if (grade % 10 >= 7)
            {
                sign = "+";
            }
            else if (grade % 10 < 3)
            {
                sign = "-";
            }
        }
        
        Console.WriteLine($"Your grade is {letter}{sign}");
    }
}