class BreathingActivity : Activity
{
    private int _repetitions = 0;

    public BreathingActivity(int duration) : base(duration){
        _startingMessage = $"Welcome to the Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void StartBreathing(){
        Console.Clear();
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
        Console.WriteLine(_description);
        DisplayAnimation();
        DisplayAnimation();
        while(_duration > 0){
            BreatheIn();
            BreatheOut();
        }
        Console.Clear();
        DisplayAnimation();
        SetEndingMessage();
        Console.WriteLine(_endingMessage);
        DisplayAnimation();
        Console.Clear();
    }

    private void BreatheIn(){
        Console.Clear();
        Console.Write("Breathe in");
        Console.WriteLine("");
        for(int i = 4; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void BreatheOut(){
        Console.Clear();
        Console.Write("Breathe out");
        Console.WriteLine("");
        for(int i = 5; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        _duration -= 9;
        _repetitions ++;
    }

    public void SetEndingMessage(){
        _endingMessage = $"Thanks for participating of the Breathing activity! You made a total of {_repetitions} repetitions";
    }

    public int GetRepetitions(){
        return _repetitions;
    }
}