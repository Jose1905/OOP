using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture learning program!");
        Console.WriteLine("Please enter the scripture (Book x:x-x): ");
        string scripture = Console.ReadLine();
        Console.WriteLine("Please enter the scripture text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Please enter the amount of words hidden per turn: ");
        int wordsPerTurn = Int32.Parse(Console.ReadLine());

        Reference newReference = new Reference(scripture, text, wordsPerTurn);

        Console.Clear();
        Console.WriteLine(newReference.GetReference());
        Console.WriteLine();

        string input = "";
        while (newReference.CheckEmptyText() == false & input != "Quit"){
            if (input == ""){
                newReference.HideWords();
                Console.WriteLine(newReference.GetText());
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue or write 'Quit' to finish the program.");
                input = Console.ReadLine();
                Console.Clear();
            }
            else if (input != "Quit"){
                Console.WriteLine("Please enter a valid input (Enter/'Quit')");
            }
        }

        // And now it came to pass that the burdens which were laid upon Alma and his brethren were made light; yea, the Lord did strengthen them that they could bear up their burdens with ease, and they did submit cheerfully and with patience to all the will of the Lord.
    }
}