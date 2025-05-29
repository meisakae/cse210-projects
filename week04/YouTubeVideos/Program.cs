using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video { Title = "Do you Hear the Poeple Sing?", Author = "LesMisCast", Length = 180 };
        video1.AddComment(new Comment("Hana", "This is literally my favorite."));
        video1.AddComment(new Comment("Minoru", "Nothing can to this!!!!"));
        video1.AddComment(new Comment("Sho", "I LOVE this song."));

        Video video2 = new Video { Title = "C# Fundamentals for Beginner", Author = "Microsft Developer", Length = 500 };
        video2.AddComment(new Comment("Bob", "Thank you. This is I need it!"));
        video2.AddComment(new Comment("MIchal", "Now I think I can learn C#."));
        video2.AddComment(new Comment("Juri", "This is helpful!"));

        Video video3 = new Video { Title = "He Is Rais", Author = "The First Presidency", Length = 240 };
        video3.AddComment(new Comment("Tom", "I know this is TRUE"));
        video3.AddComment(new Comment("Takeshi", "This is Our Hope"));
        video3.AddComment(new Comment("Akiko", "Yes! HE Is Rais!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Lenght: {video.Length} second");
            Console.WriteLine($"Number of comment: {video.GetCommentCount()}");
            Console.WriteLine("Comments: ");
            foreach (var com in video.GetComments())
            {
                Console.WriteLine($" - {com.Name}: {com.Text}");
            }
            Console.WriteLine();
        }
    }
}