using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video()
        {
            _title = "First Video",
            _author = "First Author",
            _length = 120
        };
        video1.AddComment("User 1", "Comment 1");
        video1.AddComment("User 2", "Comment 2");
        video1.AddComment("User 3", "Comment 3");
        video1.AddComment("User 4", "Comment 4");
        videos.Add(video1);

        Video video2 = new Video()
        {
            _title = "Second Video",
            _author = "Second Author",
            _length = 60
        };
        video2.AddComment("User 1", "Comment 1");
        video2.AddComment("User 2", "Comment 2");
        video2.AddComment("User 3", "Comment 3");
        videos.Add(video2);

        Video video3 = new Video()
        {
            _title = "Third Video",
            _author = "Third Author",
            _length = 240
        };
        video3.AddComment("User 1", "Comment 1");
        video3.AddComment("User 2", "Comment 2");
        video3.AddComment("User 3", "Comment 3");
        video3.AddComment("User 4", "Comment 4");
        videos.Add(video3);

        Video video4 = new Video()
        {
            _title = "Fourth Video",
            _author = "Fourth Author",
            _length = 240
        };
        video4.AddComment("User 1", "Comment 1");
        video4.AddComment("User 2", "Comment 2");
        video4.AddComment("User 3", "Comment 3");
        videos.Add(video4);

        foreach (var video in videos)
        {
            Console.WriteLine();
            video.DisplayVideo();
        }
    }
}