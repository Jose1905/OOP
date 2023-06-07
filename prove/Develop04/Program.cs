using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfulness program!");
        Console.WriteLine();

        int choice = 0;
        int duration = 0;

        while (choice != 4){
            Console.WriteLine("Menu options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.WriteLine("Select a choice from the menu");
            choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            if(choice == 1){
                Console.WriteLine("How long, in seconds, would you like for your session? ");
                duration = Int32.Parse(Console.ReadLine());
                BreathingActivity newBreathing = new BreathingActivity(duration);
                newBreathing.StartBreathing ();
            }

            else if(choice == 2){
                Console.WriteLine("How long, in seconds, would you like for your session? ");
                duration = Int32.Parse(Console.ReadLine());
                ReflectionActivity newReflection = new ReflectionActivity(duration);
                newReflection.StartReflection ();
            }

            else if(choice == 3){
                Console.WriteLine("How long, in seconds, would you like for your session? ");
                duration = Int32.Parse(Console.ReadLine());
                ListingActivity newListing = new ListingActivity(duration);
                newListing.StartListing ();
            }

            else if(choice != 4){
                Console.Clear();
                Console.WriteLine("Please select an option from 1 to 4.");
                Console.WriteLine();
            }
        }

        // Stopwatch newTimeStamp = new Stopwatch();
        // newTimeStamp.Start();
        // for (int i = 0; i < 6; i++) {
        //     Thread.Sleep(1000);
        // }
        // newTimeStamp.Stop();
        // long elapsed_time = newTimeStamp.ElapsedMilliseconds;
        // Console.WriteLine(elapsed_time);
    }
}