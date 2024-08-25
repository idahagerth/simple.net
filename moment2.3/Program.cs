using System;
class Program3
{
    static void Main()
    {
        Console.Write("Mata in grader i celsius ");                   // Skriver ut texten i consolen
        int input1 = Convert.ToInt32(Console.ReadLine());            // Läser input för terminalen och konverterar till heltal  
        Console.Write($"Det blir {input1 * 1.8 + 32} Farenheit ");  // Räknar ut celsius till farenheit
    }
}