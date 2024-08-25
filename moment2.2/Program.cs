using System;
class Program2
{
    static void Main()
    {
        Console.WriteLine("mata in ditt förnamn");               // Skriver ut texten i consolen
        string input1 = Console.ReadLine();                     // Läser input för terminalen  
        Console.WriteLine("Mata in ditt efternamn");           // Skriver ut texten i consolen
        string input2 = Console.ReadLine();                   // Läser input för terminalen
        Console.WriteLine($"Hej {input1 + " " + input2}!");  // Adderar input1 & input2 

    }
}
