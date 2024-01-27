using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Helaman", 5, 12);
        Scripture scripture = new Scripture(reference, "And now, my sons, remember, remember that it is upon the arock of our Redeemer, who is Christ, the Son of God, that ye must build your bfoundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty cstorm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        string response = "";
        bool allHidden = false;
        do{
        string displayRef = reference.GetDisplayText();
        string displayText = scripture.displayAllText();

        Console.WriteLine($"{displayRef} {displayText}");
        Console.WriteLine("Press enter to continue or type 'quit to end");
        response = Console.ReadLine();

        int hide = 5;
        scripture.hideWords(hide);

        allHidden = scripture.isCompletelyHidden();

        } while (response != "quite" && allHidden == false);
    }
}