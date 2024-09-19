using System;

class Arrays
{
    public static void Main(string[] args)
    {
        // int[] numbers = new int[] { 5, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Console.WriteLine(numbers[4]);
        // numbers[5] = 100;
        // foreach (int n in numbers)
        // {
        //     Console.WriteLine(n);
        // }

        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(" | " + matrix[i, j] + " | ");
            }
            Console.WriteLine();
        }
    }
}


