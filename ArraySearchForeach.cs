namespace BasicLinearSearch
{
    internal class Program
    {
        // Define a constant for the array size
        public const int arraySize = 5;
        static void Main(string[] args)
        {
            // Create an array to store a series of values
            int[] integerArray = new int[arraySize] { 5, 1, 4, 3, 2 };

            // Search the array for a value entered by the user
            searchArray(integerArray);


            // Display the generated array
            displayArray(integerArray);

            Console.ReadLine();
        }

        // Method to search the array for a user entered value
        private static void searchArray(int[] integerArray)
        {
            Console.WriteLine("Enter the value you want to search for: ");
            int value = int.Parse(Console.ReadLine());

            foreach (int integer in integerArray) 
            { 
                if (integer == value)
                {
                    int position = Array.IndexOf(integerArray, integer);
                    Console.WriteLine($"Item was found in position of {position + 1}");
                }
            }
        }
        // Method to display the contents of the array
        private static void displayArray(int[] integerArray)
        {
            Console.WriteLine();
            Console.Write("Array List: ");
            // Loop through the array and print each element
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(integerArray[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
