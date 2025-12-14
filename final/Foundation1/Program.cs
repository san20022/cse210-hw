using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> videoCollection = new List<Video>();

        Video video1 = new Video("A brief overview of BYU-Idaho", "BYU Idaho", 10);
        Video video2 = new Video("Campus in 2 Minutes | Get to Know BYU-Idaho", "BYU Idaho", 20);
        Video video3 = new Video("You Belong at BYU-Idaho", "BYU Idaho", 30);
        Video video4 = new Video("What I Wish I Knew Before Attending | Get to Know BYU-Idaho", "BYU Idaho", 40);

        video1.AddComment(new Comment("Rowan", "This is great!"));
        video1.AddComment(new Comment("Elliot", "Loved it"));
        video1.AddComment(new Comment("Millie", "Amazing"));

        video2.AddComment(new Comment("Kayla", "Not so good"));
        video2.AddComment(new Comment("Luis", "Could be better"));
        video2.AddComment(new Comment("Patricio", "I liked it"));

        video3.AddComment(new Comment("Noel", "WOW"));
        video3.AddComment(new Comment("Spencer", "Crazy stuff"));
        video3.AddComment(new Comment("Alan", "Nice"));

        video4.AddComment(new Comment("Braden", "Waste of time"));
        video4.AddComment(new Comment("Alex", "Awesome"));
        video4.AddComment(new Comment("Morgan", "Fantastic"));

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
