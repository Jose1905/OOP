using System;

class ReflectionActivity : Activity
{
    private List<string> _promptList = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", 
    "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questionList = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?",
     "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", 
     "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", 
     "How can you keep this experience in mind in the future?"};
      
    public ReflectionActivity(int duration) : base(duration){
        _startingMessage = $"Welcome to the Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _endingMessage = $"Thanks for participating of the Reflection activity!";
    }

    public void StartReflection(){
        Console.Clear();
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
        Console.WriteLine(_description);
        DisplayAnimation();
        DisplayAnimation();

        Console.Clear();
        Console.WriteLine(GetPrompt());
        DisplayAnimation();
        Console.Clear();

        while(_duration > 0){
            DisplayQuestion();
            Console.Clear();
        }
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

    public void DisplayQuestion(){
        int randomNum = GetRandomNumber(_questionList.Count());
        Console.WriteLine(_questionList[randomNum]);
        Console.WriteLine();
        DisplayAnimation();
        DisplayAnimation();
        _duration -= 8;
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