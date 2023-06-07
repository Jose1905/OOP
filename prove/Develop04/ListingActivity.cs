using System;
using System.Diagnostics;

class ListingActivity : Activity
{
    private List<string> _promptList = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private int _answersNumber = 0;

    public ListingActivity(int duration) : base(duration){
        _startingMessage = $"Welcome to the Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void StartListing(){
        Console.Clear();
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
        Console.WriteLine(_description);
        DisplayAnimation();
        DisplayAnimation();

        Console.Clear();
        Console.WriteLine(GetPrompt());
        DisplayAnimation();
        Console.WriteLine("\b \b");

        while(_duration > 0){
            Stopwatch newTimeStamp = new Stopwatch();
            newTimeStamp.Start();
            Console.ReadLine();
            _answersNumber += 1;
            newTimeStamp.Stop();
            long elapsed_seconds = newTimeStamp.ElapsedMilliseconds / 1000;
            _duration -= Convert.ToInt32(elapsed_seconds);
        }
        SetEndingMessage();
        Console.Clear();
        DisplayAnimation();
        Console.WriteLine(_endingMessage);
        DisplayAnimation();
        Console.Clear();
    }

    public string GetPrompt(){
        int randomNum = GetRandomNumber(_promptList.Count());
        return _promptList[randomNum];
    }

    public void SetEndingMessage(){
        _endingMessage = $"Thanks for participating of the Listing activity! You entered a total of {_answersNumber} answers";
    }

    private static readonly Random getRandom = new Random();
    public static int GetRandomNumber(int listLength)
    {
        lock(getRandom)
        {
            return getRandom.Next(listLength-1);
        }
    }
}