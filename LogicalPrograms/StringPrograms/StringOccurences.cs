using System;
using System.Collections.Generic;
using System.Text;

namespace StringPrograms
{
    class StringOccurences
    {
        #region Method1
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
                        count++; // Count first index of duplicate value..
                    }
                }
                
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(),string.Empty); // To remove after check duplicate 
            }
        }
        #endregion
       
        #region Method2
        internal static void FindDuplicateChars()
        {
            string str = "today is my birthday";
            char[] charString = str.ToCharArray();
            Dictionary<char,int> charDictionary = new Dictionary<char, int>();
            foreach (var ch in charString)
            {
                if(charDictionary.ContainsKey(ch))
                {
                    charDictionary[ch] ++;
                }
                else
                {
                    charDictionary.Add(ch,1);
                }
            }
            var keys = new HashSet<char>();
            foreach (var items in keys)
            {
                Console.WriteLine("Char {0} repeating {1} items",items,charDictionary[items]);
            }
        }
        #endregion
    }
}
