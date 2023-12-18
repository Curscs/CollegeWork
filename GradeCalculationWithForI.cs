using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_1
{
    internal class Grades
    {

        public static void Main()
        {
            //temp variables
            int choice = 0;

            do
            {
                DisplayMenu(ref choice);
                ActOnChoice(choice);
            } while (choice != 2);
        }


        public static void ActOnChoice(int choice)
        {

            switch (choice)
            {
                case 1:
                    ProcessStudents();
                    break;
                case 2:
                    //exits the program
                    break;
                default:
                    Console.WriteLine("Error, something went wrong");
                    break;

            }
        }

        public static void ProcessStudents()
        {
            string Name = "";
            int Mark = 0, StudentNum = 0;
            Getstudents(ref StudentNum);
            string[] Text = new string[StudentNum];
            for (int i = 0; i < StudentNum; i++)
            {
                GetName(ref Name);
                GetMark(ref Mark);
                ConvertToGrade(Mark, Name, i, ref Text);
            }
            DisplayStudents(Text);
        }

        public static void DisplayMenu(ref int choice)
        {
            Console.WriteLine("1 - Calculate Grade");
            Console.WriteLine("2 - Exit");
            Console.Write("Enter your choice: ");
            int.TryParse(Console.ReadLine(), out choice);
        }

        public static void Getstudents(ref int StudentsNum)
        {
            Console.Write("Enter the amount of students: ");
            int.TryParse(Console.ReadLine(), out StudentsNum);
        }
        public static void GetName(ref string Name)
        {
            Console.Write("Enter Students fullname: ");
            Name = Console.ReadLine();

        }
        public static void GetMark(ref int Mark)
        {
            Console.Write("Enter the mark achieved by student: ");
            int.TryParse(Console.ReadLine(), out Mark);
        }

        public static void ConvertToGrade(int Mark, string Name, int StudentsNum, ref string[] Text)
        {
            string[] Grades = new string[] { "A", "B", "C", "Fail" };

            if (Mark >= 50 && Mark <= 59)
            {
                Text[StudentsNum] = $"{Name} achieved {Grades[2]}";
            }
            else if (Mark >= 60 && Mark <= 79)
            {
                Text[StudentsNum] = ($"{Name} achieved {Grades[1]}");
            }
            else if (Mark >= 80)
            {
                Text[StudentsNum] = ($"{Name} achieved {Grades[0]}");
            }
            else
            {
                Text[StudentsNum] = ($"{Name} achieved {Grades[3]}");
            }
        }

        public static void DisplayStudents(string[] Text)
        {
            foreach (string Texts in Text)
            {
                Console.WriteLine(Texts);
            }
        }
    }
}
