using System;

class WrittingAssignment : Assignment
{
    private string _title;

    public WrittingAssignment() : base() {
        _title = "Unknown title";
    }

    public WrittingAssignment(string studentName, string topic, string title) : base(studentName, topic) {
        _title = title;
    }

    public string GetWrittingInformation(){
        return $"{_title} by {_studentName}";
    }
}