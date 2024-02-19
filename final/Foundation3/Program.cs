using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Upcoming Events: ");

        Lectures lecture = new Lectures("Chemistry and Leadership", "How can the chemistry that you have with your team create a deeper understanding of your leadership? Find out with these cool experiments that teach you how to grow as a leader among your teams", "April 23, 2024", "7:00 PM", "123 Main St.", "South Jordan", "Ut", "US", "Mr Science guy", 50);

        Console.WriteLine(" ");
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine(" ");
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine(" ");
        Console.WriteLine(lecture.ShortDescription());

        Receptions reception = new Receptions("Miriam Anderson & Micheal Mackay", "Miriam and Micheal are getting married!! Come party with us and enjoy some dancing, food, and socialization!", "September 23, 2024", "4:00 PM - 7:00 PM", "444 State St", "Pocatello", "ID", "US", "Email: MyEmail@Email.com \n Phone: (801) 801-8010");
        
        Console.WriteLine(" ");
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine(" ");
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine(" ");
        Console.WriteLine(reception.ShortDescription());

        OutdoorGatherings outdoor = new OutdoorGatherings("Turkey Bowl", "Come join us this year for our usual Thanksgiving Football game! Remember to dress for to cooler weather!", "November 28, 2024", "9:00 AM", "1256 Redwood Rd", "Saratoga Springs", "NY", "US", "Cloudy and cool");

        Console.WriteLine(" ");
        Console.WriteLine(outdoor.StandardDetails());
        Console.WriteLine(" ");
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine(" ");
        Console.WriteLine(outdoor.ShortDescription());

        
    }
}