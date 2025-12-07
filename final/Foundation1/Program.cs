using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videoCollection = new List<Video>();

        Video video1 = new Video("title1", "author1", 10);
        videoCollection.Add(video1);
        Video video2 = new Video("title2", "author2", 20);
        videoCollection.Add(video2);
        Video video3 = new Video("title3", "author3", 30);
        videoCollection.Add(video3);
        Video video4 = new Video("title4", "author4", 40);
        videoCollection.Add(video4);

        Comment comment1_1 = new Comment("commentator1_1", "This is a great stuff!");
        video1._comments.Add(comment1_1);
        Comment comment1_2 = new Comment("commentator1_2", "This is awseome stuff!");
        video1._comments.Add(comment1_2);
        Comment comment1_3 = new Comment("commentator1_3", "Who would have thought?!?!?!")
        video1._comments.Add(comment1_3);
        Comment comment1_4 = new Comment("commentator1_4", "Meh, there are better videos.")
        video1._comments.Add(comment1_4);
        

        
    }
}