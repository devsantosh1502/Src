using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPrograms
{
    class PalindromeProgram
    {
        internal static void GetPalindrome(int input)
        {
            int r, sum = 0, temp;
            temp = input;
            while (input > 0)
            {
                r = input % 10;
                sum = sum * 10 + r;
                input = input / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " Is a palindrome number");
            }
            else 
            {
                Console.WriteLine(temp + " Is not a palindrome number");
            }
          
        }
    }
}
