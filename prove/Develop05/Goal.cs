class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected bool _achieved;
    protected int _goalType;

    // Constructor for new Goals
    public Goal(string goalName, string description, int points){
        _goalName = goalName;
        _description = description;
        _points = points;
        _achieved = false;
        _goalType = 1;
    }

    // Constructor for Goals Read from a file
    public Goal(string goalName, string description, int points, bool achieved){
        _goalName = goalName;
        _description = description;
        _points = points;
        _achieved = achieved;
        _goalType = 1;
    }

    public string GetGoalName(){
        return _goalName;
    }

    public void SetGoalName(string goalName){
        _goalName = goalName;
    }

    public string GetDescription(){
        return _description;
    }

    public void SetDescription(string description){
        _description = description;
    }

    public int GetPoints(){
        return _points;
    }

    public void SetPoints(int points){
        _points = points;
    }

    public bool GetAchieved(){
        return _achieved;
    }

    public void SetAchieved(bool achieved){
        _achieved = achieved;
    }

    public int GetGoalType(){
        return _goalType;
    }

    public void SetGoalType(int goalType){
        _goalType = goalType;
    }

    public virtual int RecordEvent(){
        _achieved = true;
        return _points;
    }

    public virtual string DisplayGoal(){
        if (_achieved == false){
            return $"[ ] {_goalName} ({_description})";
        }
        else {
            return $"[X] {_goalName} ({_description})";
        }
    }

    public virtual string BuildFileLine(){
        return $"{_goalType},{_goalName},{_description},{_points},{_achieved}";
    }
}