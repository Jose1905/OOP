class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int points) : base(goalName, description, points){
        _goalType = 2;
    }

    public EternalGoal(string goalName, string description, int points, bool achieved) : base(goalName, description, points, achieved){
        _goalType = 2;
    }
        public override int RecordEvent(){
        return _points;
    }
}