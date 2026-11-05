using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Cook Jollof Rice", "Auntie Mary Kitchen", 600);
        video1.AddComment(new Comment("William", "Best jollof recipe I have seen!"));
        video1.AddComment(new Comment("Sarah", "I tried this and my family loved it."));
        video1.AddComment(new Comment("Kwame", "Please do one for waakye next."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Learn C# in 10 Minutes", "CSE210 Teacher", 850);
        video2.AddComment(new Comment("Ama", "This finally made classes make sense."));
        video2.AddComment(new Comment("John", "Can you explain encapsulation again?"));
        video2.AddComment(new Comment("Efua", "Very clear, thank you!"));
        video2.AddComment(new Comment("Yaw", "I passed my assignment because of this."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Ghana vs Nigeria Football Highlights", "Sports TV", 1200);
        video3.AddComment(new Comment("Kojo", "What a match!"));
        video3.AddComment(new Comment("Chidi", "That goal was amazing."));
        video3.AddComment(new Comment("Abena", "Ghana for life!"));
        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}