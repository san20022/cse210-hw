using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> videoCollection = new List<Video>();

        Video video1 = new Video("Title 1", "Author 1", 10);
        Video video2 = new Video("Title 2", "Author 2", 20);
        Video video3 = new Video("Title 3", "Author 3", 30);
        Video video4 = new Video("Title 4", "Author 4", 40);

        video1.AddComment(new Comment("User1", "This is great!"));
        video1.AddComment(new Comment("User2", "Loved it"));
        video1.AddComment(new Comment("User3", "Amazing"));

        video2.AddComment(new Comment("User4", "Not so good"));
        video2.AddComment(new Comment("User5", "Could be better"));
        video2.AddComment(new Comment("User6", "I liked it"));

        video3.AddComment(new Comment("User7", "WOW"));
        video3.AddComment(new Comment("User8", "Crazy stuff"));
        video3.AddComment(new Comment("User9", "Nice"));

        video4.AddComment(new Comment("User10", "Waste of time"));
        video4.AddComment(new Comment("User11", "Awesome"));
        video4.AddComment(new Comment("User12", "Fantastic"));

        videoCollection.Add(video1);
        videoCollection.Add(video2);
        videoCollection.Add(video3);
        videoCollection.Add(video4);

        foreach (Video video in videoCollection)
        {
            Console.WriteLine($"{video.GetTitle()} by {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.NumberOfComments()}");
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}
