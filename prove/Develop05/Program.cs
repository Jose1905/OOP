using System;

class Program
{
    static void Main(string[] args)
    {
        File newFile = new File();
        
        string option = "";
        while (option != "6"){
            option = DisplayMenu(newFile);
            if (option == "1"){
                newFile.AddGoal();
            }
            else if (option == "2"){
                newFile.GetGoalList();
            }
            else if (option == "3"){
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                newFile.SaveFile(fileName);
            }
            else if (option == "4"){
                Console.WriteLine("What is the name of the file?");
                string fileName = Console.ReadLine();
                newFile.LoadFile(fileName);
            }
            else if (option == "5"){
                newFile.AchieveGoal();
            }
            else if (option != "6"){
                Console.WriteLine("Please enter a valid number (1-6)");
                Thread.Sleep(3000);
            }
        }
    }

    static string DisplayMenu(File file){
        Console.WriteLine();
        Console.WriteLine($"You have {file.GetTotalPoints()} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Goals");
        Console.WriteLine("   6. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }
}