using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        int input_number = 1;
        int sum_total = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (input_number != 0)
        {            
            input_number = Convert.ToInt32(Console.ReadLine());
            if (input_number !=0)
            {
                numList.Add(input_number);
            }            
        }

        
        foreach (int number in numList)
        {
            sum_total += number;
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The sum is: {sum_total}");

        float average = ((float)sum_total) / numList.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");
    }
}