using System;
class Comment
{
    private string _name = "";
    private string _comment = "";
    public Comment(string name, string comment)
    {
        _name = name
        _comment = comment;
    }
    public void Display()
    {
        Console.WriteLine($"{_name} - {_comment}");
    }
}