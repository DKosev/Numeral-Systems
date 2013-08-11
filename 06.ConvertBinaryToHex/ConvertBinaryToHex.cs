using System;
using System.Text;

/* Write a program to convert binary numbers 
 * to hexadecimal numbers (directly). */

class ConvertBinaryToHex
{
    static void Main()
    {
        // Fill and print the first array
        Console.WriteLine("The array looks like:");
        string[] array = new string[] { "11011", "01010", "11001", "01011", "00011", "11110", "101111011", "10101010101011" };
        PrintArray(array);

        // Output after conversion
        Console.WriteLine(Environment.NewLine);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Binary: {0, 3} <=> Hex: {1}", array[i], BinaryToHex(array[i]));
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

    // Convert binary to hex
    private static StringBuilder BinaryToHex(string inputNumber)
    {
        string binaryLength;
        if (inputNumber.Length % 4 != 0)
        {
            binaryLength = new string('0', 4 - inputNumber.Length % 4) + inputNumber;
        }
        else
        {
            binaryLength = inputNumber;
        }

        StringBuilder hexValue = new StringBuilder();
        for (int index = 0; index < binaryLength.Length; index += 4)
        {
            switch (binaryLength.Substring(index, 4))
            {
                case "0000": 
                    hexValue.Append("0"); 
                    break;
                case "0001": 
                    hexValue.Append("1"); 
                    break;
                case "0010": 
                    hexValue.Append("2"); 
                    break;
                case "0011": 
                    hexValue.Append("3"); 
                    break;
                case "0100": 
                    hexValue.Append("4"); 
                    break;
                case "0101": 
                    hexValue.Append("5"); 
                    break;
                case "0110": 
                    hexValue.Append("6"); 
                    break;
                case "0111": 
                    hexValue.Append("7"); 
                    break;
                case "1000":
                    hexValue.Append("8"); 
                    break;
                case "1001": 
                    hexValue.Append("9"); 
                    break;
                case "1010": 
                    hexValue.Append("A");
                    break;
                case "1011":
                    hexValue.Append("B");
                    break;
                case "1100": 
                    hexValue.Append("C"); 
                    break;
                case "1101": 
                    hexValue.Append("D"); 
                    break;
                case "1110": 
                    hexValue.Append("E");
                    break;
                case "1111": 
                    hexValue.Append("F"); 
                    break;
                default: 
                    hexValue.Append(string.Empty);
                    break;
            }
        }

        return hexValue;
    }
}