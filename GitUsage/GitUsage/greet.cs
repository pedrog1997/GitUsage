using System;

public class Greeter
{
    public string Greeting { get; set; }

    void Greet()
    {
        Greeting = "Sup homies!";
        Console.WriteLine(Greeting);
    }
}
