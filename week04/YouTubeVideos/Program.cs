using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Code", "John Doe", 300);
        video1.AddComment(new Comment("Great tutorial!", "Alice"));
        video1.AddComment(new Comment("I learned a lot.", "Charlie"));
        video1.AddComment(new Comment("Thanks for sharing!", "Eve"));
        video1.DisplayVideoInfo();

        Video video2 = new Video("C# Basics", "Jane Smith", 450);
        video2.AddComment(new Comment("Very helpful, thanks!", "Bob"));
        video2.AddComment(new Comment("I appreciate the clear explanations.", "David"));
        video2.AddComment(new Comment("This is exactly what I needed.", "Frank"));
        video2.DisplayVideoInfo();

        Video video3 = new Video("Advanced C# Techniques", "Emily Johnson", 600);
        video3.AddComment(new Comment("This is a game-changer!", "Grace"));
        video3.AddComment(new Comment("I can't wait to try these techniques.", "Hannah"));
        video3.AddComment(new Comment("Your videos are always top-notch.", "Ian"));
        video3.DisplayVideoInfo();
    }
}