using System;
using System.Collections.Generic;

// CREATIVITY - Exceeding Requirements:
// 1. Library of scriptures - program has 5 scriptures and picks one at random each time.
// 2. Load from file - it tries to load scriptures from "scriptures.txt" if the file exists.
// 3. Hint system - user can type "hint" to show first letter of hidden words.
// 4. Progress counter - shows how many words are hidden / total words each round.
// 5. Only hides words that are not already hidden (stretch challenge).

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = ScriptureLibrary.LoadLibrary();

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"\nHidden: {scripture.GetHiddenCount()} / {scripture.GetTotalWords()}");
            Console.WriteLine("\nPress enter to continue, type 'hint' for a hint, or type 'quit' to finish:");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input.ToLower() == "hint")
            {
                scripture.ShowHint();
                Console.WriteLine("\nPress enter to continue...");
                Console.ReadLine();
                continue;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words hidden! Good job memorizing!");
                break;
            }
        }
    }
}