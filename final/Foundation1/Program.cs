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
        Comment comment1_3 = new Comment("commentator1_3", "Who would have thought?!?!?!");
        video1._comments.Add(comment1_3);
        Comment comment1_4 = new Comment("commentator1_4", "Meh, there are better videos.");
        video1._comments.Add(comment1_4);
        Comment comment2_1 = new Comment("commentator2_1", "This is not so great.");
        video2._comments.Add(comment2_1);
        Comment comment2_2 = new Comment("commentator2_2", "So disappointing!");
        video2._comments.Add(comment2_2);
        Comment comment2_3 = new Comment("commentator2_3", "Loved it!");
        video2._comments.Add(comment2_3);
        Comment comment3_1 = new Comment("commentator3_1", "WOW!!!!");
        video3._comments.Add(comment3_1);
        Comment comment3_2 = new Comment("commentator3_2", "I heart this!");
        video3._comments.Add(comment3_2);
        Comment comment3_3 = new Comment("commentator3_3", "CCCRRRAAAZZZYYY!!!");
        video3._comments.Add(comment3_3);
        Comment comment4_1 = new Comment("commentator3_1", "Wow, that wasted 40 seconds of my life.");
        video4._comments.Add(comment4_1);
        Comment comment4_2 = new Comment("commentator3_2", "I heart this!");
        video4._comments.Add(comment4_2);
        Comment comment4_3 = new Comment("commentator3_3", "CCCRRRAAAZZZYYY!!!");
        video4._comments.Add(comment4_3);
        Comment comment4_4 = new Comment("commentator3_4", "Who would have thought?!?!?!?");
        video4._comments.Add(comment4_4);

        foreach (Video video in videoCollection)
        {
            Console.Write($"{video.GetVideoName()}, by {video.GetAuthor()}, is {video.GetLength()} seconds long, and has {video.NumberOfComments()} comments.\n");
            video.DisplayListOfComments();
            Console.Write("\n");
        }
    }   
}