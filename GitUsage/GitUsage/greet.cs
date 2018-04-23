using System;

public class Greeter
{
    public string Greeting { get; set; }

    void Greet(string name, int age)
    {
<<<<<<< HEAD
        Console.WriteLine("Greetings");
        Greeting = "Sup homies!";

        Console.WriteLine(Greeting);
=======
        Console.WriteLine($"Hello {name} you are {age} years old.");
>>>>>>> Arno-twoparam
    }
}
