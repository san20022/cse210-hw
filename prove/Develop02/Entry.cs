using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Mood { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Date} - {Prompt}");
        Console.WriteLine(Response);
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{Date}|{Prompt}|{Response}|{Mood}";
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry
        {
            Date = parts[0],
            Prompt = parts[1],
            Response = parts[2],
            Mood = parts[3]
        };
    }
}