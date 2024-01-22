using System;
using System.Collections.Generic;
using System.IO;  // Don't forget to add this directive
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
public class DataStorage
{
    private const string PlayerDataFile = "C:\\GameDataFolder\\player_data.txt";
    public static void SaveData(string fileName, string Data)
    {
        File.WriteAllText(fileName, Data);
    }

    public static string ReadData(string fileName)
    {
        if (File.Exists(fileName))
        {
            return File.ReadAllText(fileName);
        }
        else
        {
            return "File not found.";
        }
    }

    public static void SavePlayerData(Player player)
    {
        SaveData(PlayerDataFile, player.username);
    }

    public static void LoadPlayerData(Player player)
    {
        string savedData = ReadData(PlayerDataFile);
        if (!string.IsNullOrEmpty(savedData))
        {
            player.username = savedData;
        }
    }
}
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

    public void OpenEgg(string eggname)
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
        //class info retrieve
        Eggs eggInstance = new Eggs();
        Player player = new Player();
        //Load Data
        DataStorage.LoadPlayerData(player);
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

        DataStorage.SavePlayerData(player);
    }
}
