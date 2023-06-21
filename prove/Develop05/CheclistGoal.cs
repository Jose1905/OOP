class ChecklistGoal : Goal
{
    protected int _timesForBonus;
    protected int _timesRecorded;
    protected int _bonusPoints;

    public ChecklistGoal(string goalName, string description, int points, int timesForBonus, int bonusPoints) : base(goalName, description, points){
        _timesForBonus = timesForBonus;
        _bonusPoints = bonusPoints;
        _timesRecorded = 0;
        _goalType = 3;
    }

    public ChecklistGoal(string goalName, string description, int points, bool achieved, int timesForBonus, int timesRecorded, int bonusPoints) : base(goalName, description, points, achieved){
        _timesForBonus = timesForBonus;
        _bonusPoints = bonusPoints;
        _timesRecorded = 0;
        _goalType = 3;
    }

    public int GetTimesForBonus(){
        return _timesForBonus;
    }

    public void SetTimesForBonus(int timesForBonus){
        _timesForBonus = timesForBonus;
    }

    public int GetTimesRecorded(){
        return _timesRecorded;
    }

    public int GetBonusPoints(){
        return _bonusPoints;
    }

    public void SetBonusPoints(int bonusPoints){
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent(){
        if (_timesRecorded == (_timesForBonus - 1)){
            _timesRecorded ++;
            _achieved = true;
            return _points + _bonusPoints;
        }
        else if (_timesRecorded < (_timesForBonus - 1)){
            _timesRecorded ++;
            return _points;
        }
        else {
            return _points;
        }
    }

    public override string DisplayGoal(){
        if (_achieved == false){
            return $"[ ] {_goalName} ({_description}) -- Currently completed: {_timesRecorded}/{_timesForBonus}";
        }
        else {
            return $"[X] {_goalName} ({_description}) -- Currently completed: {_timesRecorded}/{_timesForBonus}";
        }
    }

    public override string BuildFileLine(){
        return $"{_goalType},{_goalName},{_description},{_points},{_achieved},{_timesForBonus},{_timesRecorded},{_bonusPoints}";
    }
}