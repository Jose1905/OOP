using System;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    
    public void ReadFile()
    {
        Console.WriteLine("What is the name of the document?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry readEntry = new Entry();
            readEntry._prompt = parts[0];
            readEntry._answer = parts[1];
            readEntry._date = parts[2];

            _entryList.Add(readEntry);
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("What is the name of the document?");
        string fileName = Console.ReadLine();
        WriteLines(fileName, _entryList);
        Console.WriteLine($"Document saved under the name {fileName}");
    } 

    private static void WriteLines(string fileName, List<Entry> entryList)
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