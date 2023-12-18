using System;
using System.ComponentModel;

public class LotteryGame
{
    static List<int> Winnums = new List<int>();
    private static void Main()
    {
        int choice = 0;
        do
        {
            Display_Menu();
            Get_Choice(ref choice);
            Act_On_Choice(choice);
        } while (choice != 3);
    }

    private static void Display_Menu()
    {
        Console.WriteLine("Lotter Game Admin Panel");
        Console.WriteLine("=======================");
        Console.WriteLine("1 - Set win numbers");
        Console.WriteLine("2 - Play the lottery");
        Console.WriteLine("3 - Exit");
    }

    private static void Get_Choice(ref int choice)
    {
        Console.Write("Enter your choice: ");
        int.TryParse(choice.ToString(), out choice);
    }
    private static void Act_On_Choice(int choice)
    {
        switch(choice) {
            case 1:
                SetWinNumbers();
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }

    private static void SetWinNumbers()
    {
        int temp = 0, amountnum = 0;
        Console.Write("Enter the amount of winning numbers: ");
        int.TryParse(amountnum.ToString(), out amountnum);

        for (int i = 0; i < amountnum; i++)
        {
            Console.WriteLine($"Enter the winning  {i + 1}");
            int.TryParse(temp.ToString(), out temp);

            Winnums[i] = temp;
        }
    }

    private static void RunLottery()
    {
        int luckynumber = 0;
        Console.Write("Enter your lucky number: ");

    }
}
