using System;
class Program4
{
    static void Main()
    {
        Console.WriteLine("Cirkelns radie: ");                    // Skriver ut texten i consolen
        int input1 = Convert.ToInt32(Console.ReadLine());        // Läser input för terminalen och konverterar till heltal  
        Console.WriteLine("Area: ");                            // Skriver ut texten i consolen
        Console.WriteLine($"{Math.PI * Math.Pow(input1,2)}");  // Räknar ut pi gånger radien upphöjt till 2
        Console.WriteLine("Omkrets: ");                       // Skriver ut texten i consolen
        Console.WriteLine($"{Math.PI * 2 * input1}");        // Räknar ut omkretsen
    }
}

