using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video v1 = new Video("Ulitmate Fails", "FunnyGuy2", 400);

        v1.AddComment("DaDude", "First Comment");
        v1.AddComment("SlyDog", "Haha :') So Funny!");
        v1.AddComment("Slayer", "Best video ever!!");

        Video v2 = new Video("Best Trick Shots Ever", "TrixMaster", 200);

        v2.AddComment("MasterDestro", "Wow man, how did you do that?");
        v2.AddComment("Superdupper", "Thats so fake. Not even possible.");
        v2.AddComment("Yesumm", "Been there done that 10x better");

        Video v3 = new Video("Cinnamon Challenge", "LetsGoo45", 30);

        v3.AddComment("TimTim", "What are you doing? That's stupid!");
        v3.AddComment("HectoSpector3", "Thats a sure way to die");
        v3.AddComment("NicTic", "What hs this world come to?");

        Video v4 = new Video("Minecraft Speed Run", "Miner4Life33", 700);

        v4.AddComment("Scootdar33", "That's the fastes I've ever seen someone complete Minecraft?");
        v4.AddComment("ScamFinder77", "No way you did it that fast. You swapped to creative mode");
        v4.AddComment("PineChopper12", "Minecraft is life!!");

        _videos.Add(v1);
        _videos.Add(v2);
        _videos.Add(v3);
        _videos.Add(v4);

        foreach(Video v in _videos)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Video: {v.VideoInformation()}");
            Console.WriteLine($"{v.CommentCount()} comments.");
            Console.WriteLine(" ");
            v.DesplayComments();
        }
    }
}