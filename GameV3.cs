using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

public class Player
{
    public string username { get; set; } = "";
    public List<string> Items { get; set; } = new List<string>();
}

public class Eggs
{
    public Dictionary<string, Dictionary<string, double>> eggs = new Dictionary<string, Dictionary<string, double>>
    {
        {
            "Common Egg", new Dictionary<string , double>
            {
                {"Doggy", 30.0},
                {"Cat", 30.0},
                {"Demon", 0.9}
            }
        }
    };

    public void OpenEgg(string eggname)
    {
        if (eggs.ContainsKey(eggname))
        {
            //retrieve data from dictionary
            Dictionary<string , double> eggContents = eggs[eggname];


            //Calculate total pet chance
            double TotalChance = 0;
            foreach (var petChance in eggContents.Values)
            {
                TotalChance += petChance;
            }

            //Generates random number and then * it by the totalchance 
            double randomnumber = new Random().NextDouble() * TotalChance;

            foreach (var petChance in eggContents)
            {
                if (randomnumber <= petChance.Value) 
                {
                    Console.WriteLine($"You have got {petChance.Key}");
                    break;
                }

                randomnumber -= petChance.Value;
            }
        }
        else
        {
            Console.WriteLine($"Egg with name '{eggname}' not found.");
        }
    }

}

public class Program
{
    public static void Main()
    {
        Eggs eggInstance = new Eggs();
        for (int i = 0; i < 100; i++) 
        {
            eggInstance.OpenEgg("Common Egg");
        }
    }
}
