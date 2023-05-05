using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        List<Entry> entryList = new List<Entry>();

        //Program loop
        string choice = "";
        Console.WriteLine("Welcome to the journal program!");
        
        do
        {
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry();
                int randomNum = getRandomNumber(prompts.Count());
                string selectedPrompt = prompts[randomNum];
                newEntry._prompt = selectedPrompt;

                Console.WriteLine(selectedPrompt);
                newEntry._answer = Console.ReadLine();
                DateTime currentDateTime = DateTime.Now;
                newEntry._date = currentDateTime.ToShortDateString();

                entryList.Add(newEntry);
            }

            else if (choice == "2")
            {
                foreach (Entry e in entryList)
            {
                e.DisplayAnswer();
            } 
            }

            else if (choice == "3")
            {
                entryList.Clear();
                Console.WriteLine("What is the name of the document?");
                string docName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(docName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    Entry readEntry = new Entry();
                    readEntry._prompt = parts[0];
                    readEntry._answer = parts[1];
                    readEntry._date = parts[2];

                    entryList.Add(readEntry);
                }
            }

            else if (choice == "4")
            {
                
                Console.WriteLine("What is the name of the document?");
                string docName = Console.ReadLine();
                SaveFile(docName, entryList);
                Console.WriteLine($"Document saved under the name {docName}");
            }

            else if (choice != "5")
            {
                Console.WriteLine("Please enter a valid number");
            }

        } while (choice != "5");

        

    }

    private static readonly Random getRandom = new Random();

    public static int getRandomNumber(int listLength)
    {
        lock(getRandom)
        {
            return getRandom.Next(listLength-1);
        }
    }    

    public static void SaveFile(string fileName, List<Entry> entryList)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in entryList)
            {
                outputFile.WriteLine($"{e._prompt},{e._answer},{e._date}");
            }            
        }
    }
}