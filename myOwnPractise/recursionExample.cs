using System;

class Program
{
    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main(string[] args)
    {
        int number = 5;
        Console.WriteLine("Factorial of " + number + " is " + Factorial(number));
    }
}
