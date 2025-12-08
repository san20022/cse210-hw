using System;
class Video
{
    private string _title = "";
    private string _author = "";
    private int _lengthInSeconds = 0;
    public List<Comment> _comments = new List<Comment>();
    public Video(){}
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }
    public int NumberOfComments()
    {
        return _comments.Count();
    }
    public string GetVideoName()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _lengthInSeconds;
    }
    public void DisplayListOfComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}