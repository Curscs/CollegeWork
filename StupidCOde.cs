using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Revision
    {
        public static void Main()
        {
            int choice = 0;
            do
            {
                Display_Menu();
                Get_Choice(ref choice);
                Act_On_Choice(choice);
            } while (choice != 5);

        }

        public static void Display_Menu()
        {
            //Display menu
            Console.WriteLine("Function System Menu");
            Console.WriteLine("====================");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Calculate area");
            Console.WriteLine("3 - Celsius to fahrenheit");
            Console.WriteLine("4 - Greetings");
            Console.WriteLine("5 - Exit");
        }

        public static void Get_Choice(ref int choice)
        {
            Console.Write("Enter your choice: ");
            int.TryParse(Console.ReadLine(), out choice);
        }

        public static void Act_On_Choice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    CalculateArea();
                    break;
                case 3:
                    FtoC();
                    break;
                case 4:
                    Greetings();
                    break;
                case 5:
                    Console.WriteLine("Successfully exited the program");
                    break;
                default:
                    break;

            }
        }

        public static void Sum()
        {
            int firstnum = 0, secondnum = 0;
            Console.Write("Enter first number: ");
            int.TryParse(Console.ReadLine(), out firstnum);

            Console.Write("Enter second number: ");
            int.TryParse(Console.ReadLine(), out secondnum);

            int answer = firstnum + secondnum;

            Console.WriteLine($"answer is {answer}");
        }

        public static void CalculateArea()
        {
            int width = 0, breadth = 0;
            Console.Write("Enter width: ");
            int.TryParse(Console.ReadLine(), out width);

            Console.Write("Enter breadth: ");
            int.TryParse(Console.ReadLine(), out breadth);

            int area = width * breadth;
        }

        public static void FtoC()
        {
            double fern = 0;
            Console.Write("Enter celsius: ");
            double.TryParse(Console.ReadLine(), out fern);
            double celsius = (fern - 32) * 5 / 9;

            Console.WriteLine($"the answer is {celsius}");
        }

        public static void Greetings()
        {
            Console.WriteLine("Enter your fullname: ");
            string fullname = Console.ReadLine();

            string[] doc = fullname.Split(" ");

            string firstname = doc[0].ToUpper();
            string secondname = doc[1].ToUpper();

            Console.WriteLine($"Greetings, {firstname} {secondname}. DIE!!!");
        }
    }
}
