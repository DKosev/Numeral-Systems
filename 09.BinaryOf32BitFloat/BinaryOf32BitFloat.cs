using System;

/* * Write a program that shows the internal binary representation
 * of given 32-bit signed floating-point number in IEEE 754 
 * format (the C# type float). Example: -27,25  sign = 1, 
 * exponent = 10000011, mantissa = 10110100000000000000000. */

class BinaryOf32BitFloat
{
    static void Main()
    {
        // Input
        float floatNumber = -27.25f;

        // Convert the input to Int32
        int floatToInt = BitConverter.ToInt32(BitConverter.GetBytes(floatNumber), 0);

        // Convert the Int32 to string
        string inputToString = Convert.ToString(floatToInt, 2);

        // Detect the sign
        string detectSign = inputToString.Substring(0, 1);

        // Find the exponent
        string findExponent = inputToString.Substring(1, 8);

        // Fin the mantissa
        string findMantissa = inputToString.Substring(9, 23);

        // Output
        Console.Write("{0} => ", floatNumber);
        Console.Write("sign = {0}, ", detectSign);
        Console.Write("exponent = {0}, ", findExponent);
        Console.Write("mantissa = {0}", findMantissa);
        Console.WriteLine();
    }
}