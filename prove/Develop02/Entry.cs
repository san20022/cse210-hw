using System;

public class Entry
{
    public string _Date;
    public string _Prompt;
    public string _Response;
    public string _Mood;

    public void Display()
    {
        Console.WriteLine($"{_Date} - {_Prompt}");
        Console.WriteLine(_Response);
        Console.WriteLine($"Mood: {_Mood}");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{_Date}|{_Prompt}|{_Response}|{_Mood}";
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry
        {
            _Date = parts[0],
            _Prompt = parts[1],
            _Response = parts[2],
            _Mood = parts[3]
        };
    }
}