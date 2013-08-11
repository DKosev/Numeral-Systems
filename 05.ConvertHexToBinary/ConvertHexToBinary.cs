using System;

/* Write a program to convert hexadecimal 
 * numbers to binary numbers (directly). */

class ConvertHexToBinary
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
            string[] array = new string[arrayLength];
            FillArray(array);
            PrintArray(array);

            // Output after conversion
            Console.WriteLine(Environment.NewLine);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Hex: {0, 3} <=> Binary: {1}", array[i], ConvertToHex(array[i]));
            }
        }
    }

    // Fill the array with random hex
    private static void FillArray(string[] array)
    {
        int min = 1;
        int max = 1000;
        Random randNum = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randNum.Next(min, max).ToString("X");
        }
    }

    // Print the filled array
    private static void PrintArray(string[] array)
    {
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write("{0, 2} ", array[j]);
        }
    }

    // Convert hex to binary
    private static string ConvertToHex(string hexValue)
    {
        hexValue = Convert.ToString(Convert.ToInt32(hexValue, 16), 2);

        return hexValue;
    }
}