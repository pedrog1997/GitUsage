using System;

public class Greeter
{
    public string Greeting { get; set; }

    void Greet()
    {
        Console.WriteLine("Greetings");
        Greeting = "Sup homies!";

        Console.WriteLine(Greeting);
    }
}
