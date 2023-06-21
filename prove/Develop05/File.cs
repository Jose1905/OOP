using System.IO;

class File
{
    private string _fileName;
    private List<Goal> _goalList;
    private int _totalPoints;

    // Constructor for creating a file at the start of the program
    public File(){
        _fileName = "No Name";
        _goalList = new List<Goal>();
        _totalPoints = 0;
    }

    // Constructor in case a new file will be created
    public File(string fileName, List<Goal> goalList, int totalPoints){
        _fileName = fileName;
        _goalList = goalList;
        _totalPoints = 0;
    }

    public string GetFileName(){
        return _fileName;
    }

    public void SetFileName(string fileName){
        _fileName = fileName;
    }

    public int GetTotalPoints(){
        return _totalPoints;
    }

    public void AddGoal(){
        string goalType = "";
        while (goalType != "1" && goalType != "2" && goalType != "3"){
            Console.WriteLine("What type of goal would you like to add? (1. Simple / 2. Eternal / 3. Checklist)");
            goalType = Console.ReadLine();
        }        
        Console.WriteLine("What is the name of the goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is the description of the goal? ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points for completing the goal? ");
        int goalPoints = Int32.Parse(Console.ReadLine());
        if (goalType == "1"){
            Goal newGoal = new Goal(goalName, goalDescription, goalPoints);
            _goalList.Add(newGoal);
        }
        else if (goalType == "2"){
            EternalGoal newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goalList.Add(newGoal);
        }
        else if (goalType == "3"){
            Console.WriteLine("How many times does this goal have to be accomplished for a bonus? ");
            int bonusTimes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = Int32.Parse(Console.ReadLine());
            ChecklistGoal newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, bonusTimes, bonusPoints);
            _goalList.Add(newGoal);
        }
    }

    public void GetGoalList(){
        Console.Clear();
        if (_goalList.Count() == 0){
            Console.WriteLine("This file is still empty!");
        }
        else {
            for (int i = 0; i < _goalList.Count(); i ++){
                Console.WriteLine($"{i+1}. {_goalList[i].DisplayGoal()}");
            }
        }
    }

    public void AchieveGoal(){
        GetGoalList();
        Console.WriteLine();
        Console.WriteLine("Which goal did you achieve? ");
        int goalNumber = Int32.Parse(Console.ReadLine());
        int earnedPoints = _goalList[goalNumber - 1].RecordEvent();
        _totalPoints += earnedPoints;
    }

    public void AddPoints(int Points){
        _totalPoints += Points;
    }

    public void SaveFile(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            
            for (int i = 0; i < _goalList.Count(); i++){
                outputFile.WriteLine(_goalList[i].BuildFileLine());
            }            
        }
    }

    public void LoadFile(string fileName){
        string[] lines = System.IO.File.ReadAllLines(fileName);

        for (int i = 0; i < lines.Count(); i++)
        {
            if (i == 0){
                _totalPoints = Int32.Parse(lines[i]);
            }
            else {
                ReadGoal(lines[i]);
            }            
        }
    }

    public void ReadGoal(string line){
        string[] parts = line.Split(",");
        int goalType = Int32.Parse(parts[0]);
        string goalName = parts[1];
        string goalDescription = parts[2];
        int goalPoints = Int32.Parse(parts[3]);
        bool achieved = Convert.ToBoolean(parts[4]);
        if (goalType == 1){
            Goal newGoal = new Goal(goalName, goalDescription, goalPoints, achieved);
            _goalList.Add(newGoal);
        }
        else if (goalType == 2){
            EternalGoal newGoal = new EternalGoal(goalName, goalDescription, goalPoints, achieved);
            _goalList.Add(newGoal);
        }
        else {
            int timesForBonus = Int32.Parse(parts[5]);
            int timesRecorded = Int32.Parse(parts[6]);
            int bonusPoints = Int32.Parse(parts[7]);
            ChecklistGoal newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, achieved, timesForBonus, timesRecorded, bonusPoints);
            _goalList.Add(newGoal);
        }
    }
}