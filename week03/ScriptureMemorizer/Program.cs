// Creativity:
// I exceeded the core requirements by creating a small scripture library.
// The program can randomly select from multiple scriptures, giving users
// more variety and making scripture memorization practice more engaging.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16);

        Scripture scripture1 = new Scripture(
            reference1,
            "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"
        );


        Reference reference2 = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture2 = new Scripture(
            reference2,
            "Trust in the Lord with all your heart and lean not on your own understanding"
        );

        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(scripture1);
        scriptures.Add(scripture2);

        Random random = new Random();

        int index = random.Next(scriptures.Count);

        Scripture scripture = scriptures[index];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            Console.WriteLine("Press enter to continue or type quit to finish:");

            string input = Console.ReadLine();


            if (input.ToLower() == "quit")
            {
                break;
            }


            scripture.HideRandomWords(3);
        }


        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Good job practicing your scripture!");
    }
}