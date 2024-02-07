using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class Player
{

    public string Usernames { get; set; } = "";
    public List<string> Items { get; set; } = new List<string>();

    public void AddItem(string item)
    {
        Items.Add(item);
    }

    public void CreateUsername(string username)
    {
        Usernames = username;
    }

    public void RemoveItem(string item)
    {

    }
}

public class Control
{
    private static List<Player> players;

    public static void Main()
    {
        Init();
        DisplayListsContents(players);
    }


    public static void Init()
    {
    }

    private static void DisplayListsContents(List<Player> players)
    {
        Console.WriteLine("Contents of Lists:");

        foreach (var player in players)
        {
            Console.WriteLine("Player's Items:");

            foreach (var item in player.Items)
            {
                Console.WriteLine($"- {item}");
            }

            foreach (var username in player.Usernames)
            {
                Console.WriteLine($"- {username}");
            }

            Console.WriteLine();
        }
    }

    public static void ProcessCreation()
    {
        AdminConsole.CreatePlayers();
        AdminConsole.CreateUsernames(players);
    }
}

public class MenuProgram
{
    public static void DisplayMenu(ref int choice)
    {
        Console.WriteLine("Super Menu");
        Console.WriteLine("===============");
        Console.WriteLine("1 - Console");
        Console.WriteLine("2 - Game (Soon)");
        Console.WriteLine("3 - Quit");
        Util.CheckTypeInt(ref choice, "choice");
    }

    public static void ActOnChoice(int choice)
    {
        switch (choice)
        {
            case 1:

                break;

            case 2:

                break;

            case 3:

                break;

            default:

                break;
        }
    }
}
public class AdminConsole
{
    public static void CreatePlayers()
    {
        int PlayerAmount = 0;

        Console.Write("Enter the amount of players you want to create: ");
        Util.CheckTypeInt(ref PlayerAmount, "number players");

        Player.

    }

    public static void CreateUsernames(List<Player> players)
    {
        for (int i = 0; i < players.Count; i++)
        {
            string TempUsername = "";
            Console.Write($"Enter username of player {i + 1}: ");
            Util.CheckTypeString(ref TempUsername, "username");

            players[i].CreateUsername(TempUsername);
        }
    }
}

public class Util
{
    public static void CheckTypeInt(ref int targetVariable, string Name)
    {
        while (!int.TryParse(Console.ReadLine(), out targetVariable))
        {
            Console.WriteLine($"Invalid input. Please enter a valid integer for the {Name}.");
            Console.Write($"Enter the {Name}: ");
        }
    }

    public static void CheckTypeString(ref string targetVariable, string Name)
    {
        targetVariable = Console.ReadLine();
        while (string.IsNullOrEmpty(targetVariable))
        {
            Console.WriteLine($"Invalid input. Please enter a valid string for {Name}.");
            Console.Write($"Enter {Name}: ");
            targetVariable = Console.ReadLine();
        }
    }
}
