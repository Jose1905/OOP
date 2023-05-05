using System;
using System.IO;

public class Entry
{
    public string _prompt;
    public string _answer;
    public string _date;

    public void DisplayAnswer()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_answer);
        Console.WriteLine("");
    }
}