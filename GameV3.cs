using System;
using System.Collections.Generic;
using System.IO;  // Don't forget to add this directive
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
public class Player
{
    public string username { get; set; } = "";
    public List<string> Items { get; set; } = new List<string>();
    public List<string> Pets { get; set; } = new List<string>();

    public void AddPet(string PetName, Player player)
    {
        player.Pets.Add(PetName);
    }
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

        },
        {
            "Rare Egg", new Dictionary<string , double>
            {
                {"Doggy", 30.0},
                {"Cat", 30.0},
                {"Demon", 0.9}
            }
        },
    };

    public void OpenEgg(string eggname, Player player)
    {
        if (eggs.ContainsKey(eggname))
        {
            //retrieve data from dictionary
            Dictionary<string, double> eggContents = eggs[eggname];


            //Calculate total pet chance
            double TotalChance = 0;
            foreach (var petChance in eggContents.Values)
            {
                TotalChance += petChance;
            }

            //Generates random number and then * it by the totalchance 
            double randomnumber = new Random().NextDouble() * TotalChance;

            foreach (var Petname in eggContents)
            {
                if (randomnumber <= Petname.Value)
                {
                    player.AddPet(Petname.Key, player);
                    Console.WriteLine($"You have hatched {Petname.Key}");
                    break;
                }

                randomnumber -= Petname.Value;
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
        //class info retrieve
        Eggs eggInstance = new Eggs();
        Player player = new Player();
        //functions
        Startup(player);
    }
    public static void Startup(Player player)
    {
        Console.WriteLine("Welcome to Console World");
        if (player.username == "")
        {
            GetUsername(player);
        }
    }
    public static void GetUsername(Player player)
    {
        Console.Write("Enter your username: ");
        player.username = Console.ReadLine();
    }
}
