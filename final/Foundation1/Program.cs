using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 300);
        video1.AddComment("User1", "This is a great video!");
        video1.AddComment("User2", "Awesome content!");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 240);
        video2.AddComment("User3", "Nice work!");
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 420);
        video3.AddComment("User4", "I learned a lot from this.");
        video3.AddComment("User5", "Keep up the good work!");
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetAllComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}
