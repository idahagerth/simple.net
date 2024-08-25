using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Mata in tal 1:");                          // Skriver ut texten i consolen
        int input1 = Convert.ToInt32(Console.ReadLine());            // Läser input för terminalen och konverterar till heltal  
        Console.WriteLine("Mata in tal 2:");                        // Skriver ut texten i consolen
        int input2 = Convert.ToInt32(Console.ReadLine());          // Läser input för terminalen och konverterar till heltal
        Console.WriteLine($"Summan: {input1 + input2}");          // Adderar input1 & input2 
        Console.WriteLine($"Multiplikation: {input1 * input2}"); // multiplicerar input1 & input2 
        Console.WriteLine($"division: {input1 / input2}");      // dividerar input1 & input2 
    }
}
 