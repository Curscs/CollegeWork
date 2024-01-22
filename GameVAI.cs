using System;
using System.Collections.Generic;

public class Player
{
    public string Username { get; set; } = "";
    public List<string> Items { get; set; } = new List<string>();
}

public class Eggs
{
    public Dictionary<string, Dictionary<string, double>> eggs = new Dictionary<string, Dictionary<string, double>>
    {
        {
            "Rare Egg", new Dictionary<string, double>
            {
                {"Super Mega Pet", 0.001},
                {"Easy Pet", 30.0},
                {"Common Pet", 69.999}
            }
        }
        // Add other egg types with their respective pets and chances here
    };

    public void OpenEgg(string eggName)
    {
        if (eggs.ContainsKey(eggName))
        {
            Dictionary<string, double> eggContents = eggs[eggName];

            // Calculate total chances
            double totalChances = 0;
            foreach (var petChance in eggContents.Values)
            {
                totalChances += petChance;
            }

            // Generate a random number between 0 and the total chances
            double randomNumber = new Random().NextDouble() * totalChances;

            // Determine which pet the player gets based on the random number
            foreach (var petChance in eggContents)
            {
                if (randomNumber <= petChance.Value)
                {
                    Console.WriteLine($"You got a {petChance.Key}!");
                    break;
                }

                randomNumber -= petChance.Value;
            }
        }
        else
        {
            Console.WriteLine($"Egg with name '{eggName}' not found.");
        }
    }
}

public class Program
{
    private static Player currentPlayer = new Player();

    private static void Main()
    {
        Eggs eggsInstance = new Eggs();
        eggsInstance.OpenEgg("Rare Egg");
    }
}
