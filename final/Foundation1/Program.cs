using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();

        // create the videos
        Video video1 = new Video("The Matrix Is Real", "The Conspirators", 136, new List<Comment>());
        Video video2 = new Video("The Earth Is Flat", "The Flat Earthers", 120, new List<Comment>());
        Video video3 = new Video("Dogs being funny", "Dog Lovers", 60, new List<Comment>());

        // create the comments
        Comment comment1 = new Comment("This is scary!", "John Smith");
        Comment comment2 = new Comment("What a bunch of baloney!", "hat3r");
        Comment comment3 = new Comment("Wow that is so interesting", "Jane Doe");
        Comment comment4 = new Comment("How could you believe this?", "highIQ");
        Comment comment5 = new Comment("How could you NOT believe this?", "higherIQ");
        Comment comment6 = new Comment("If you liked the video, checkout this news outlet: www.realfakenews.com", "The Flat Earthers");
        Comment comment7 = new Comment("I love the cute puppies", "Janice");
        Comment comment8 = new Comment("Poor thing could've gotten hurt!", "ConcernedUser");
        Comment comment9 = new Comment("I can't stop watching this! So funny.", "bigdoglover");

        // add the comments to the videos
        video1.comments.Add(comment1);
        video1.comments.Add(comment2);
        video1.comments.Add(comment3);
        video2.comments.Add(comment4);
        video2.comments.Add(comment5);
        video2.comments.Add(comment6);
        video3.comments.Add(comment7);
        video3.comments.Add(comment8);
        video3.comments.Add(comment9);

        // add the videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // print out the videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Video Name: {video.title}");
            Console.WriteLine($"Author: {video.author}");
            Console.WriteLine($"Length: {video.length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"Author: {comment.author} || Comment: {comment.text}");
                Console.WriteLine($"");
            }
            Console.WriteLine();
        }

    }
}