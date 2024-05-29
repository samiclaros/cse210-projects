using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Playing FC25 for first time!", "Edgar Patibara", 700);
        Comment comment1 = new Comment("Carlos66", "Nice work!");
        Comment comment2 = new Comment("Papayita", "So cool!");
        Comment comment3 = new Comment("Loquendo", "Exactly what I wanted!");
        Console.WriteLine(""); // BLANK

        Video video2 = new Video("I hate this game!", "Lola832", 900);
        Comment comment2_1 = new Comment("kwi777", "I get scared!");
        Comment comment2_2 = new Comment(">>BOYGAMEPLAYS>>", "That was easy, noob");
        Comment comment2_3 = new Comment("programWithSharpie", "I scrolled down too much..");
        Console.WriteLine(""); // BLANK

        Video video3 = new Video("Leave gaming, start programming", "charke822", 900);
        Comment comment3_1 = new Comment("gigies", "What is that?");
        Comment comment3_2 = new Comment("noobiewobie", "Dislike, I love your gameplays!");
        Comment comment3_3 = new Comment("asmsw212", "Why did you leave the videogames?");
        Console.WriteLine(""); // BLANK
        //
        video1.Display();
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Console.WriteLine(""); // BLANK
        Console.WriteLine("Comments:");
        foreach (Comment comment in video1.GetComments())
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine($"This is the number of comments: {video1.GetCommentCount()}");
        //
        video2.Display();
        video2.AddComment(comment2_1);
        video2.AddComment(comment2_2);
        video2.AddComment(comment2_3);
        
        Console.WriteLine(""); // BLANK
        Console.WriteLine("Comments:");
        foreach (Comment comment in video2.GetComments())
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine($"This is the number of comments: {video2.GetCommentCount()}");
        ////
        video3.Display();
        video3.AddComment(comment3_1);
        video3.AddComment(comment3_2);
        video3.AddComment(comment3_3);

        Console.WriteLine(""); // BLANK
        Console.WriteLine("Comments:");
        foreach (Comment comment in video3.GetComments())
        {
            Console.WriteLine(comment.GetComment());
        }
        Console.WriteLine($"This is the number of comments: {video3.GetCommentCount()}");
    }
}
