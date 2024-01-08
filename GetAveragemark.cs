using System;
using System.Xml.Schema;

public class Task
{
    private static void Main()
    {
        int[] Marks = new int[5];
        int AverageMark = 0;
        GetMarks(ref  Marks);
        CalculateAverage(Marks, ref AverageMark);
        DisplayAverage(AverageMark);
    }

    private static void GetMarks(ref int[] Marks)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter mark {i + 1}");
            Marks[i] = int.Parse( Console.ReadLine() );
        }
    }

    private static void CalculateAverage(int[] Marks, ref int AverageMark)
    {
        int TotalMarks = 0;

        for (int i = 0; i < 5; i++)
        {
            TotalMarks += Marks[i];
        }
        AverageMark = TotalMarks / Marks.Length;
        Console.WriteLine(TotalMarks);

    }

    private static void DisplayAverage(int Displayable)
    {
        Console.WriteLine($"The average mark is ${Displayable}");
    }
}
