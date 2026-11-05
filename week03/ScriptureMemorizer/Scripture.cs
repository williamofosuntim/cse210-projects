using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int count = Math.Min(numberToHide, visibleWords.Count);
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public int GetHiddenCount()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public int GetTotalWords()
    {
        return _words.Count;
    }

    public void ShowHint()
    {
        // Show hint for first hidden word - simplified: we just show message
        // Hint display is handled by temporarily showing first letters in Word
        Console.Clear();
        string text = _reference.GetDisplayText() + " ";
        bool hintShown = false;
        foreach (Word word in _words)
        {
            if (word.IsHidden() && !hintShown)
            {
                text += word.GetHintText() + " ";
                hintShown = true;
            }
            else
            {
                text += word.GetDisplayText() + " ";
            }
        }
        Console.WriteLine(text.Trim());
        Console.WriteLine("\nHint: First letter of one hidden word shown above ^");
    }
}

public static class ScriptureLibrary
{
    public static List<Scripture> LoadLibrary()
    {
        List<Scripture> library = new List<Scripture>();

        // Try to load from file if it exists
        if (System.IO.File.Exists("scriptures.txt"))
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
                foreach (string line in lines)
                {
                    // Format: Book|Chapter|Verse|EndVerse|Text
                    string[] parts = line.Split('|');
                    if (parts.Length == 5)
                    {
                        Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                        library.Add(new Scripture(reference, parts[4]));
                    }
                }
                if (library.Count > 0)
                {
                    return library;
                }
            }
            catch { }
        }

        // Default library
        library.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."));
        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths."));
        library.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."));
        library.Add(new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        library.Add(new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."));

        return library;
    }
}