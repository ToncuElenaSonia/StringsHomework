using System;
using System.Text;

namespace LastPart
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "https://www.siit.com/net-exercises";
            RemoveLastPart(s1);
            string str = "awesome string";

            CheckIfStart(str);

            string str1 = "alabala portocala";
            string str2 = "ala";
            OccurencesSubstring(str1, str2);

            string str3 = "32.054,23";
            SwapCommaAndDot(str3);

            Console.WriteLine("Enter the string for removing spaces from it:");
            string str4 = Console.ReadLine();
            Console.WriteLine("The string without spaces is:");
            Console.WriteLine(RemoveWhitespace(str4));

            Console.WriteLine("Give the string to check if it is palindrome: ");
            string ab = Console.ReadLine();
            Palindrom(ab);
        }
        //Write a method to get the last part of a string before a specified character.
        //Input :  https://www.siit.com/net-exercises
        //Output:  https://www.siit.com/net
        static void RemoveLastPart(string s)
        {
            char[] myArray = s.ToCharArray();
            foreach (char c in myArray)
            {
                if (c == '-')
                {
                    s = s.Remove(s.IndexOf(c));
                }
            }
            Console.WriteLine($"The new string is:{s}");
        }
        //Write a method to check whether a string starts with specified characters
        public static string CheckIfStart(string s)
        {
            Console.WriteLine("Enter the character to verify if the string starts with it:");
            string ch = Console.ReadLine();
            char[] myArray = ch.ToCharArray();
            foreach (char c in myArray)
            {
                if (s.StartsWith(c.ToString(), true, new System.Globalization.CultureInfo("en-us")))
                {
                    Console.WriteLine("Yes,{0} it starts with this character", s, c);
                }
                else
                {
                    Console.WriteLine($"No, don't start with this character");
                }
            }
            return (s);
        }
        //Write a method to count occurrences of a substring in a string.
        static void OccurencesSubstring(string strOccurrence, string valSubstring)
        {
            var countOccurrence = 0;
            for (int i = 0; i < strOccurrence.Length; i++)
            {
                if (i == strOccurrence.IndexOf(valSubstring, i))
                {
                    countOccurrence++;
                }
            }
            Console.WriteLine($"The number of occurrences of the substring 'ala' in string 'alabala portocala' is:{countOccurrence}");
        }
        //•	Write a method to swap comma and dot in a string (buna).
        //Input: "32.054,23"
        //Output: "32,054.23"
        static void SwapCommaAndDot(string s)
        {
            char[] myArray = s.ToCharArray();
            //int indexOfDot = s.IndexOf('.');
            //int indexOfComma = s.IndexOf(',');

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == '.')
                {
                    s = s.Remove(i, 1);
                    s = s.Insert(i, ",");
                }
                else
                {
                    if (myArray[i] == ',')
                    {
                        s = s.Remove(i, 1);
                        s = s.Insert(i, ".");
                    }
                }
            }
            Console.WriteLine($"The string that we swap comma and dot is:{s}");
        }
        //•	Write a method to remove spaces from a given string.
        static string RemoveWhitespace(string input)
        {
            StringBuilder output = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsWhiteSpace(input, i))
                {
                    output.Append(input[i]);
                }
            }
            return output.ToString();
        }
        // Check if a string is palindrome(same value read from left to right and right to left) Ex: alabala -> True
        static void Palindrom(string str1)
        {
            int n = str1.Length - 1;
            int m = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str1[n - i])
                {
                    m++;
                }
                if (m != 0)
                {
                    Console.WriteLine("The string is not palindrom");
                    break;
                }
            }
            if (m == 0)
            {
                Console.WriteLine("The string is palindrom");
            }
        }
    }
}
