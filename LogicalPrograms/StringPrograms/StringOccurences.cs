using System;
using System.Collections.Generic;
using System.Text;

namespace StringPrograms
{
    class StringOccurences
    {
        internal static void getCountDuplicateChar() 
        {
            string str = "hello santosh";
            while (str.Length > 0) // Iterate loop to reach at last index.
            {
                Console.Write(str[0] + ": "); // To Display each char of string
                int count = 0; // Store count value of each string.

                for (int i = 0; i < str.Length; i++) // Iterate loop from strating index to last index to find duplicate char.
                {
                    if (str[0] == str[i]) // To chek first index of value is match with given char.
                    {
                        count++; // Count char.
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(),string.Empty); // To remove after check duplicate 
            }
        }
    }
}
