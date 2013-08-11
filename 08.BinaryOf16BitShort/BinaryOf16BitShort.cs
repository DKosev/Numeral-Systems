using System;

/* Write a program that shows the binary representation of 
 * given 16-bit signed integer number (the C# type short). */

class BinaryOf16BitShort
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
            short[] array = new short[arrayLength];
            FillArray(array);
            PrintArray(array);

            // Output after conversion
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    ShortToBinary(array[i]);
                    Console.WriteLine("Number: {0, 3} <=> Binary: {1}", array[i], ShortToBinary(array[i]));
                }
                else
                {
                    ShortToBinary(65536 + array[i]);
                    Console.WriteLine("Number: {0, 3} <=> Binary: {1}", array[i], ShortToBinary(array[i]));
                }
            }
        }
    }

    // Fill the array with random numbers
    private static void FillArray(short[] array)
    {
        short min = -32768;
        short max = 32767;
        Random randNum = new Random();
        for (short i = 0; i < array.Length; i++)
        {
            array[i] = (short)randNum.Next(min, max);
        }
    }

    // Print the filled array
    private static void PrintArray(short[] array)
    {
        for (short j = 0; j < array.Length; j++)
        {
            Console.Write("{0, 2} ", array[j]);
        }
    }

    // Convert short to binary
    private static string ShortToBinary(int number)
    {
        char[] binaryArray;
        string binaryResult = string.Empty;

        for (int i = 0; i < 16; i++)
        {
            if (number % 2 == 0)
            {
                binaryResult += 0;
                number = number / 2;
            }
            else
            {
                binaryResult += 1;
                number = number / 2;
            }
        }

        binaryArray = binaryResult.ToCharArray();
        Array.Reverse(binaryArray);
        binaryResult = new string(binaryArray);

        return binaryResult;
    }
}