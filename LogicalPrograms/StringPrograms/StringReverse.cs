using System;
using System.Collections.Generic;
using System.Text;

namespace StringPrograms
{
    class StringReverse
    {
        internal static void GetStringReverse() 
        {
            Console.WriteLine("Please enter a string value.");
            string input = Console.ReadLine(), // Taking Input From User.
                temp = string.Empty; // Store the temporary variable .
           
            for (int i = input.Length-1; i >= 0; i--) // Loop is used to iterate from last last to first index.
            {
                temp = temp + input[i]; // To store current value with index value.
            }
            Console.WriteLine(temp); // Display output
        }
    }
}
