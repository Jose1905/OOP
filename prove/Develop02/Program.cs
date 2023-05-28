using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _prompts = new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        Journal _newJournal = new Journal();

        //Program loop
        string _choice = "";
        Console.WriteLine("Welcome to the journal program!");
        
        do
        {
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            _choice = Console.ReadLine();

            if (_choice == "1")
            {
                Entry newEntry = new Entry();
                int randomNum = GetRandomNumber(_prompts.Count());
                string selectedPrompt = _prompts[randomNum];
                newEntry._prompt = selectedPrompt;

                Console.WriteLine(selectedPrompt);
                newEntry._answer = Console.ReadLine();
                DateTime currentDateTime = DateTime.Now;
                newEntry._date = currentDateTime.ToShortDateString();

                _newJournal._entryList.Add(newEntry);
            }

            else if (_choice == "2")
            {
                foreach (Entry e in _newJournal._entryList)
            {
                e.DisplayAnswer();
            } 
            }

            else if (_choice == "3")
            {
                _newJournal._entryList.Clear();
                _newJournal.ReadFile();                
            }

            else if (_choice == "4")
            {
                _newJournal.SaveFile();
            }

            else if (_choice != "5")
            {
                Console.WriteLine("Please enter a valid number");
            }

        } while (_choice != "5");

        

    }

    private static readonly Random getRandom = new Random();

    public static int GetRandomNumber(int listLength)
    {
        lock(getRandom)
        {
            return getRandom.Next(listLength-1);
        }
    }    

    // public static void SaveFile(string fileName, List<Entry> entryList)
    // {
    //     using (StreamWriter outputFile = new StreamWriter(fileName))
    //     {
    //         foreach (Entry e in entryList)
    //         {
    //             outputFile.WriteLine($"{e._prompt},{e._answer},{e._date}");
    //         }            
    //     }
    // }
}