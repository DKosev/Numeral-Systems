using System;

/* Write a program to convert binary numbers 
 * to their decimal representation. */

class ConvertBinaryToDecimal
{
    static void Main()
    {
        // Fill and print the first array
        Console.WriteLine("The array looks like:");
        string[] array = new string[] { "11011", "01010", "11001", "01011" };
        PrintArray(array);
            
        // Output after conversion
        Console.WriteLine(Environment.NewLine);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Binary: {0, 3} <=> Number: {1}", array[i], ToDecimal(array[i]));
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

    // Convert binary to decimal
    private static int ToDecimal(string number)
    {
        int decNum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            decNum = decNum << 1;
            if (number[i] == '1')
            {
                decNum = decNum ^ 1;
            }
        }

        return decNum;
    }
}