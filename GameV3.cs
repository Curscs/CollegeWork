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

public class Pet
{
    public string Name { get; set; }
    public double Attack { get; set; }
    public double Health { get; set; }

    public class Mobs
    {
        public Dictionary<string, Dictionary<string, (Pet, int)>> mobs = new Dictionary<string, Dictionary<string, (Pet, int)>>
        {

        };

    }

    public class Eggs
    {
        public Dictionary<string, Dictionary<string, (Pet, int)>> eggs = new Dictionary<string, Dictionary<string, (Pet, int)>>
    {
            {
                "Common Egg", new Dictionary<string, (Pet, int)>
                {
                    {"Doggy", (new Pet { Name = "Doggy", Attack = 3, Health = 20}, 30)},
                    {"Cat", (new Pet { Name = "Doggy", Attack = 3, Health = 20}, 30)},
                    {"Bear", (new Pet { Name = "Bear", Attack = 3, Health= 20}, 10)},
                    
                }
            }
    };

        public void OpenEgg(string eggname, Player player)
        {
            if (eggs.ContainsKey(eggname))
            {
                //retrieve data from dictionary
                Dictionary<string, (Pet, int)> eggContents = eggs[eggname];


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
            ConsoleGame.Startup(player);
        }
    }

    public class ConsoleGame
    {
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
        public static void OptionsDisplay(ref int choice)
        {
            Console.WriteLine("Here are some of your options:");
            Console.WriteLine("1 - Go on adventure");
            Console.WriteLine("2 - Open shop");
            Console.WriteLine("3 - Exit the game");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
        }

        public static void ActOnChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;

            }
        }

        public static void GoOnAdventure()
        {

        }


    }
