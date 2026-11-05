using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _mood;

    public Entry(string date, string promptText, string entryText, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
    }

    public void Display()
    {
        int wordCount = _entryText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood} | Words: {wordCount}");
        Console.WriteLine(_entryText);
    }

    public string GetAsFileLine()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}~|~{_mood}";
    }

    public static Entry FromFileLine(string line)
    {
        string[] parts = line.Split("~|~");
        if (parts.Length < 4)
        {
            return null;
        }
        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}