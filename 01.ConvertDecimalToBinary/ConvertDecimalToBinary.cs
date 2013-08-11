using System;

/* Write a program to convert decimal numbers 
 * to their binary representation. */

class ConvertDecimalToBinary
{
    static void Main()
    {
        // Input
        Console.Write("Enter the length of the array:\n=> ");
        int arrayLength = int.Parse(Console.ReadLine());
        if (arrayLength <= 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\aError! The array length have to be greater than 0.\n");
            Console.ResetColor();
            Main();
        }
        else
        {
            // Fill and print the array
            Console.WriteLine("The array looks like:");
            int[] array = new int[arrayLength];
            FillArray(array);
            PrintArray(array);
            
            // Output after conversion
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Number: {0, 3} <=> Binary: {1}", array[i], DecimalToBinary(array[i]));
            }
        }
    }

    // Fill the array with random numbers
    private static void FillArray(int[] array)
    {
        int min = 1;
        int max = 1000;
        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(min, max);
        }
    }

    // Print the filled array
    private static void PrintArray(int[] array)
    {
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write("{0, 2} ", array[j]);
        }
    }

    // Convert decimal to binary
    private static string DecimalToBinary(int number)
    {
        int binaryHolder;
        char[] binaryArray;
        string binaryResult = string.Empty;

        while (number > 0)
        {
            binaryHolder = number % 2;
            binaryResult += binaryHolder;
            number = number / 2;
        }

        binaryArray = binaryResult.ToCharArray();
        Array.Reverse(binaryArray);
        binaryResult = new string(binaryArray);

        return binaryResult;
    }
}