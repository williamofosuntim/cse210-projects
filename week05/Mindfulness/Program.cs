using System;

// CREATIVITY - EXCEEDS CORE REQUIREMENTS:
// 1. Added a 4th activity: GratitudeActivity (inherits from Activity)
// 2. No random prompt/question repeats until all have been used once in that session (used lists in Reflecting/Listing)
// 3. Session log: Program tracks and displays how many activities completed in this session

class Program
{
    static void Main(string[] args)
    {
        int activitiesDone = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start gratitude activity (EXTRA)");
            Console.WriteLine("  5. Quit");
            Console.Write($"Activities completed this session: {activitiesDone}\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
                activitiesDone++;
            }
            else if (choice == "2")
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
                activitiesDone++;
            }
            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity();
                l.Run();
                activitiesDone++;
            }
            else if (choice == "4")
            {
                GratitudeActivity g = new GratitudeActivity();
                g.Run();
                activitiesDone++;
            }
            else if (choice == "5")
            {
                Console.WriteLine($"Goodbye! You completed {activitiesDone} activities today.");
                break;
            }
        }
    }
}