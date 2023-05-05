using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

public class Entry
{
    public string _prompt;
    public string _answer;

    public void DisplayAnswer()
    {
        Console.WriteLine(_prompt);
        Console.WriteLine(_answer);
    }
}