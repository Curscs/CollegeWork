using System;

//function Display_Menu() { displays a text menu for user }
//function Get_Choice() { will ask for user input and will store that input as choice }
//function Act_On_Choice() { will do something based on what was stored in variable choice }
//function string_function() { will display users forename and will ask for users fullname and will create username out of it }
/*function  number_function() { 
    will ask user for random number , will also generate number from 1-10. using users number and random number it will
    ask for an answer. If user got it wrong it will get him back to menu if he got it wrong it will display a times table
 */
//function create_name() { this will create username for function string_function, it will use your names first letter and will combine with your full surname}

public class FunctionSystemMenu
{
    //Global Variable
    static string forename = "";
    private static void Main()
    {
        //Variables
        int choice = 0;
        Console.Write("Enter your forename: ");
        forename = Console.ReadLine();

        //Code
        Console.WriteLine($"Welcome to the Function System {forename}");
        do
        {
            Display_Menu();
            Get_choice(ref choice);
            Act_on_choice(choice);
        } while (choice != 3);
    }
    
    private static void Display_Menu()
    {
        //Display menu
        Console.WriteLine("Function System Menu");
        Console.WriteLine("====================");
        Console.WriteLine("1 - String function");
        Console.WriteLine("2 - Number function");
        Console.WriteLine("3 - Exit");
    }

    private static void Get_choice(ref int choice)
    {
        //Variables
        Console.Write("Enter your choice: ");
        string temp_choice = Console.ReadLine();

        //Code
        if (int.TryParse(temp_choice, out choice))
        {
            Console.WriteLine("This is a legal integer");
        }
        else
        {
            Console.WriteLine("This is NOT a legal integer");
        }
        
    }


    private static void Act_on_choice(int choice)
    {
        switch (choice)
        {
            case 1:
                string_function();
                break;
            case 2:
                number_function();
                break;
            case 3:
                Console.WriteLine("You have chosen the exit option");
                break;
            default:
                Console.WriteLine("Error. Incorrect choice. Please try again");
                break;
        }
    }

    private static void string_function()
    {
        //Variables
        Console.WriteLine($"This is Option 1, {forename}");
        Console.Write("Enter your full name (forename and surename): ");
        string fullname = Console.ReadLine();

        //Code
        create_name(fullname);
    }

    private static void number_function()
    {
        //Variables
        int times_table,random_number,answer,user_answer = 0;
        Random rnd = new Random();
        Console.WriteLine($"This is Option 2, {forename}");
        Console.Write("Enter the value of the times table to test: ");
        int.TryParse(Console.ReadLine(), out times_table);

        //Code
        if (times_table > 0)
        {
            random_number = rnd.Next(10) + 1;
            answer = times_table * random_number;

            Console.Write($"What is {times_table} * {random_number} ? ");
            int.TryParse(Console.ReadLine(), out user_answer);

            if (answer != user_answer)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{times_table} * {i} = {times_table * i}");
                }
            }
            else
            {
                Console.WriteLine("Welldone, you got it correct");
            }

        }
        else
        {
            Console.WriteLine("Enter a positive whole number greater than 0");
        }
    }

    private static void create_name(string fullname)
    {
        //Variables
        char initial = fullname[0];
        int spaceIndex = fullname.IndexOf(" ") + 1;
        string surname = fullname.Substring(spaceIndex);
        string username = initial + surname;

        //Code
        
        Console.WriteLine($"Your new username is {username}");
        
    }
}