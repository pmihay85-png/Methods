using System;

class MethodForGreetings
{
    static string MagicGreeting(string name)
    {
        string[] greetings =
        {
            $"Welcome, mighty {name}!",
            $"Greetings, traveler {name}!",
            $"Hail, noble {name}!",
            $"Behold, the legendary {name} has arrived!"
        };

        Random r = new Random();
        return greetings[r.Next(greetings.Length)];
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine(MagicGreeting(userName));
    }
}
