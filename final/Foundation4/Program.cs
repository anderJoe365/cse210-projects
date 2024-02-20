using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();

        Running running = new Running("01 Feb 2024", 45, 3);
        Cycling cycling = new Cycling("08 Feb 2024", 45, 10);
        Swimming swimming = new Swimming("14 Feb, 2024", 30, 5);

        activity.Add(running);
        activity.Add(cycling);
        activity.Add(swimming);

        foreach(Activity a in activity)
        {
            Console.WriteLine(a.Summary());
        }
    }
}