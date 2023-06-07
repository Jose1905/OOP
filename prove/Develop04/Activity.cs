class Activity
{
    protected string _startingMessage;
    protected string _endingMessage;
    protected string _description;
    protected int _duration;

    public Activity(int duration){
        _duration = duration;
    }
    
    public string GetStartingMessage(){
        return _startingMessage;
    }

    public string GetEndingMessage(){
        return _endingMessage;
    }

    public string GetDescription(){
        return _description;
    }

    public string GetDuration(){
        return $"{_duration} seconds";
    }

    public void DisplayAnimation(){
        for(int i = 2; i > 0; i--){
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("—");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}