using System;

/* Write a program to convert from any numeral system of given
 * base s to any other numeral system of base d (2 ≤ s, d ≤  16). */

class ConvertAnyNumeralSystem
{
    static void Main()
    {        
        // Input
        Console.Write("Enter the number:\n=> ");
        string inputNumber = Console.ReadLine();
        Console.Write("Now enter the 's' value:\n=> ");
        int valueS = int.Parse(Console.ReadLine());
        if (valueS < 2)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\aError! The 's' value have to be greater or equal to 2.\n");
            Console.ResetColor();
            Main();
        }

        Console.Write("Enter the 'd' value:\n=> ");
        int valueD = int.Parse(Console.ReadLine());
        if (valueD > 16)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\aError! The 'd' value have to be greater or equal to 16.\n");
            Console.ResetColor();
            Main();
        }
        else if (valueD == valueS)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\aThe bases have to be different to convert the number.\n");
            Console.ResetColor();
            Main();
        }

        // Convert to 10 base number
        int resultTemp = 0;
        for (int i = 0; i < inputNumber.Length; i++)
        {
            resultTemp += Convert.ToInt32(inputNumber.Substring(i, 1)) * (int)Math.Pow(valueS, inputNumber.Length - 1 - i);
        }

        // Convert from 10 base to base 'd' and print the result
        string result = FromDecimalToX(resultTemp, valueD);
        Console.WriteLine(result);
    }
    
    // Convert from decimal to 'd' base
    private static string FromDecimalToX(int number, int valueD)
    {
        string result = string.Empty;
        while (number > 0)
        {
            switch (number % valueD)
            {
                case 0: 
                    result += "0"; 
                    break;
                case 1: 
                    result += "1"; 
                    break;
                case 2: 
                    result += "2"; 
                    break;
                case 3: 
                    result += "3"; 
                    break;
                case 4: 
                    result += "4"; 
                    break;
                case 5: 
                    result += "5"; 
                    break;
                case 6: 
                    result += "6"; 
                    break;
                case 7: 
                    result += "7";
                    break;
                case 8: 
                    result += "8"; 
                    break;
                case 9: 
                    result += "9"; 
                    break;
                case 10: 
                    result += "A";
                    break;
                case 11: 
                    result += "B";
                    break;
                case 12: 
                    result += "C"; 
                    break;
                case 13: 
                    result += "D"; 
                    break;
                case 14: 
                    result += "E"; 
                    break;
                case 15: 
                    result += "F"; 
                    break;
            }

            number = number / valueD;
        }

        // Reverse the number
        string tempResult = string.Empty;
        for (int i = result.Length - 1; i >= 0; i--)
        {
            tempResult += result[i];
        }

        result = tempResult;
        return result;
    }
}