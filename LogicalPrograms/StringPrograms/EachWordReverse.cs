using System;
using System.Collections.Generic;
using System.Text;

namespace StringPrograms
{
    class EachWordReverse
    {
        internal static void GetEachWordReverse()
        {
            string inputStr = Console.ReadLine();
            string[] splitStr = inputStr.Split(' ');
            string newStr = string.Empty;
            foreach (var item in splitStr)
            {
                string temp = string.Empty;
                char[] charArr = item.ToCharArray();
                for (int i = charArr.Length - 1; i >= 0;i--)
                {
                    temp = temp + charArr[i];
                }
                newStr = newStr + temp + " ";
            }
            Console.WriteLine(newStr);
        }
    }
}
