/* 
 useful scripts for me to remember:

 1) foreach (var (x, index) in x.value.Select((value, i) => (value, i + 1)))
 2) (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
 
 
 
 
 */
public class Player
{
    public string username { get; set; } = "";
    public int coins { get; set; } = 0;
    public List<string> weaponInventory = new List<string>();
    public List<string> items = new List<string>();

    public void AddItem(string itemName)
    {
        items.Add(itemName);
    }
}

public class Weapon
{
    public string name { get; set; }
    public string rarity { get; set; }
    public int damage { get; set; }
}

public class Crate
{
    private static readonly Dictionary<string, Dictionary<string, (Weapon, int)>> crate = new Dictionary<string, Dictionary<string, (Weapon, int)>>
    {
        {
            //weapon (name , rarity , damage) item1
            //chance item2

            "Common Crate", new Dictionary<string, (Weapon, int)>
            {
                {"Wooden Sword", (new Weapon { name = "Wooden Sword", rarity = "Common", damage = 5}, 30)},
                {"Long wooden sword", (new Weapon { name = "Long Wooden Sword", rarity = "Rare", damage = 10}, 10)}
            }
        }
    };

    private static readonly Dictionary<string,(int, string)> crateStat = new Dictionary<string, (int, string)>
    {
        {"Common Crate", (300, "Coins")} //parameter 1 - crate name , parameter 2 - price, parameter 3 - currency
    };

    static Random random = new Random();

    public static IEnumerable<Weapon> GetAllWeapons()
    {
        foreach (var crate in  crate) 
        {
            foreach (var weapon in crate.Value)
            {
                yield return weapon.Value.Item1;
            }
            
        }
    }

    public static IEnumerable<(string Egg, int Index)> GetAllCrates()
    {
        foreach (var (egg,index) in crate.Keys.Select((value, i) => (value, i + 1)))
        {
            yield return (Egg: egg, Index: index);
        }
    }

    public static bool CheckIfPlayerHasEnoughCurrency(Player playerInstance, int price)
    {
        if (playerInstance.coins >= price)
        {
            return true;
        }
        return false;
    }

    public static void BuyCrate(int choice)
    {
        int crateprice;
        foreach (var (price,index) in crateStat.Select((value, i) => (value, i + 1)))
        {
            if choice 
        }
        if (Player.CheckIfPlayerHasEnoughCurrency())
        {

        }
    }

    public static void OpenCrate(string crateName)
    {
        if (crate.ContainsKey(crateName))
        {
            //access crate data
            Dictionary<string,(Weapon, int)> crateData = crate[crateName];

            //total weapon chances
            double totalChance = crateData.Values.Sum(weaponData => weaponData.Item2);
            //generate random number * by total chance
            double randomNum = random.NextDouble() * totalChance;
            double cumulativeChance = 0;
            foreach (var (weapon, chance) in crateData.Values)
            {
                cumulativeChance += chance;
                if (randomNum <= cumulativeChance) 
                {
                    Console.WriteLine($"you have unboxed {Utils.articleCheck(weapon.rarity)} {weapon.name}");
                    return;
                }
            }
        }
    }
}

public class World
{

}

public class ConsoleFunctions
{
    public static void MainMenu(ref int choice)
    {
        Console.WriteLine("Main menu");
        Console.WriteLine("===============");
        Console.WriteLine("1 - Open inventory");
        Console.WriteLine("2 - Open marketplace");
        Console.WriteLine("3 - Go hunt");
        Console.WriteLine(" ");
        Console.Write("Enter what you want to do: ");
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Error , please try again");
            Console.Write("Enter what you want to do: ");
        }

    }
    
    public static void HandleChoice(int choice)
    {
        switch (choice)
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;

        }
    }

    public static void OpenInventory(Player playerInstance)
    {
        Console.WriteLine("Your Inventory");
        foreach (var (item, index) in playerInstance.items.Select((value, i) => (value, i + 1)))
        {
            Console.WriteLine($"{index}) {item}");
        }
    }

    public static void OpenMarketplace(Player playerInstance)
    {
        int choice = -1, lastCrateIndex;

        Console.WriteLine($"Coins: {playerInstance.coins}");
        Console.WriteLine("");
        Console.WriteLine("Marketplace");
        foreach (var (egg, index) in Crate.GetAllCrates())
        {
            Console.WriteLine($"{index}) {egg}");

            lastCrateIndex = index;
        }
        Console.Write("Enter the number of the crate you want to open (0 to go back to main menu): ");
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < -1)
        {
            Console.WriteLine("Error , please try again");
            Console.WriteLine("Enter the number of the crate you want to open (0 to go back to main menu): ");
        }
    }

    public static void OpenIndex(Player playerInstance) 
    {
        foreach (var (weapon, index) in Crate.GetAllWeapons().Select((value, i) => (value, i + 1)))
        {
            string discovery = "(Undiscovered)";
            foreach (var playerweapon in playerInstance.weaponInventory)
            {
                if (playerweapon == weapon.name)
                {
                    discovery = "(Discovered)";
                }
            }
            Console.WriteLine($"{index}) {weapon.name} {discovery}");
        }
    }
}

public class Utils
{
    public static string articleCheck(string word)
    {
        string[] vowelChars = { "A", "a", "E", "e", "I", "i", "O", "o" };
        foreach (var character in vowelChars)
        {
            if (word.StartsWith(character))
            {
                return $"an {word}";
            }
        }
        return $"a {word}";
    }

    public static void DebugDisplay(object variable, string description)
    {
        Console.WriteLine($"{variable} = {description}");
    }
}

public class Program
{
    public static void Main()
    {
        Player playerInstance = new Player();
        ConsoleFunctions.OpenInventory(playerInstance);
        ConsoleFunctions.OpenMarketplace(playerInstance);
    }
}
