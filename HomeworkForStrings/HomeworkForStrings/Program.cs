using System;
using System.Text;
using System.Globalization;


namespace HomeworkForStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the index of the character: ");
            int index1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The new string is: " + RemoveIndex(index1, 1));

            Console.WriteLine("Please enter the string for removing the characters which have odd index values:");
            string problema2 = Console.ReadLine();
            Console.WriteLine(RemoveOdd(problema2));

            Console.WriteLine("Please enter text for up and lower cases:");
            string textToConvert = Console.ReadLine();
            Console.WriteLine(TextlowerUpper(textToConvert));

            Console.WriteLine("Please enter the string that will be reverse:");
            string textToReverse = Console.ReadLine();
            Console.WriteLine(Reverse(textToReverse));

            Console.WriteLine("Please enter the text that wil be create uppercase:");
            string text1 = Console.ReadLine();
            CheckString(text1);

            Console.WriteLine("Before remove newline, the old string is: ");
            TheOldStringIs();
            string myNewString = "this is\nmy homework\nfor today because I\rdidn't have time to do it";
            Console.WriteLine("After remove newline,the new string is: ");
            RemoveNewLine(myNewString.Replace("\n", " ").Replace("\r", " "));

            Console.WriteLine("Give the string that will be formatted per line: ");
            string s = Console.ReadLine();
            Displays50(s);
            Console.WriteLine();

            Console.WriteLine("Indroduce the number for percentage:");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine(GetPercentage(a));

            Console.WriteLine("Please enter the string for reverse it:");
            string textToRev = Console.ReadLine();
            Console.WriteLine($"After reverse, the string is:{ReverseAgain(textToRev)}");

            Console.WriteLine("Please enter the string for strip a set of characters:");
            string stringForRemove = Console.ReadLine();
            Console.WriteLine("Please enter the remove chars from string: ");
            string removeCharsFromString = Console.ReadLine();
            Console.WriteLine($"After strip a set of characters, the new string is:");
            StrippedString(stringForRemove, removeCharsFromString);

            Console.WriteLine("Please enter the text for transform lowercase the first n characters: ");
            string myNString = Console.ReadLine();
            Console.WriteLine("Please enter the length of substring: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The string with first {0} lowercase characters is: ", n);
            TransformLowercase(myNString, n);

            Console.WriteLine("Please enter the text to capitalize the first and last letters of each word: ");
            string mySecondString = Console.ReadLine();
            Console.WriteLine("The string with upper and lower letter of the word is ");
            FirstAndLastCharacter(mySecondString);

            Console.WriteLine("Enter the string to compute the sum of digits ");
            string myThirdString = Console.ReadLine();
            ComputeTheSumOfDigits(myThirdString);


        }
        //Write a method that to remove the nth index character from a nonempty string.
        static string RemoveIndex(int index, int length)
        {
            string someString = "This is my homework";
            return someString.Remove(index, 1);
        }
        //Write a method that to remove the characters which have odd index values of a given string.
        static string RemoveOdd(string text1)
        {
            StringBuilder text2 = new StringBuilder();
            for (int i = 0; i < text1.Length; i++)
            {
                if (i % 2 == 0)
                {
                    text2.Append(text1[i]);
                }
            }
            return text2.ToString();
        }
        //•	Write a method that takes input from the user and displays that input back in lower cases.
        static string TextlowerUpper(string textTochange)
        {
            string texTnou = "";
            return texTnou = "Lowercase=" + textTochange.ToLower() + "\nUpperCase =" + textTochange.ToUpper();
        }
        //•	Write a method that reverses a string if it's length is a multiple of 4
        static string Reverse(string stringReverse)
        {
            StringBuilder newStringReverse = new StringBuilder();
            for (int i = stringReverse.Length - 1; i >= 0; i--)
            {
                if ((stringReverse.Length - 1) % 4 != 0)
                {
                    newStringReverse.Append(stringReverse[i]);
                    Console.WriteLine(newStringReverse.ToString());
                }
                else
                {
                    Console.WriteLine("The length of string must be multiple of 4");
                }
            }
            return newStringReverse.ToString();
        }
        //•	Write method to convert a given string to all uppercase if it contains 
        //at least 2 uppercase characters in the first 4 characters.
        static void CheckString(string text)
        {
            int con = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    con = con + 1;
                }
            }
            if (con < 2)
            {
                Console.WriteLine("The first two characters must be uppercase!");
            }
            else
            {
                Console.WriteLine($"The strint with all uppercase  if it contains at least 2 uppercase is: {text = text.ToUpper()}");
            }
        }
        //•	Write a method that to remove a newline.
        static void TheOldStringIs()
        {
            Console.WriteLine("this is\nmy homework\nfor today because I\rdidn't have time to do it");
        }
        static void RemoveNewLine(string myString)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in myString)
            {
                sb.Append(c);
            }
            Console.WriteLine(sb.ToString());
        }
        //•	Write a method to display formatted text (width=50) as output. For example: If I 
        // have a text that's 134 characters long, the formatted string should have maximum 
        //of 50 characters per line. In this case we will have 3 lines of text.
        static void Displays50(string unstring)
        {
            Console.WriteLine("Characters per line:");
            for (int j = 0; j < unstring.Length; j++)
            {
                if ((j + 1) % 50 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(unstring[j]);
            }
        }
        //•	Write a method that formats a number with a percentage
        static string GetPercentage(double number)
        {
            return number.ToString("P2");
        }
        //•	Write a method that reverses a string.
        static string ReverseAgain(string stringRev)
        {
            StringBuilder newStringRev = new StringBuilder();

            for (int i = stringRev.Length - 1; i >= 0; i--)
            {
                newStringRev.Append(stringRev[i]);
                Console.WriteLine(newStringRev.ToString());
            }

            return newStringRev.ToString();
        }
        //•	Write a method that strips a set of characters from a string
        static void StrippedString(string testString, string removeChars)
        {
            char[] myArray = removeChars.ToCharArray();
            CultureInfo[] cultureOf = { CultureInfo.CreateSpecificCulture("en-US") };
            string result = testString;
            foreach (char c in myArray)
            {
                foreach (var cult in cultureOf)
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (char.ToUpper(c, cult) == char.ToUpper(result[i], cult))
                        {
                            result = result.Remove(i, 1);
                        }
                        else
                        {
                            if (char.ToLower(c, cult) == char.ToLower(result[i], cult))
                            {
                                result = result.Remove(i, 1);
                            }
                        }
                    }
                }

                Console.WriteLine(result);
            }
        }
        //•	Write a method that transforms to lowercase first n characters in a string
        static void TransformLowercase(string myString, int lengthOfSubstring)
        {
            string newString2 = myString;
            for (int i = 0; i < myString.Length; i++)
            {
                if (i < lengthOfSubstring && char.IsUpper(myString[i]))
                {
                    newString2 = newString2.Substring(0, lengthOfSubstring);
                }
            }
            Console.WriteLine(newString2.ToLower() + myString.Substring(lengthOfSubstring));
        }
        //  •	Write a method to capitalize first and last letters of each word of a given string.
        static void FirstAndLastCharacter(string myS)
        {
            char[] altArray = myS.ToCharArray();
            altArray[0] = Char.ToUpper(altArray[0]);
            altArray[myS.Length - 1] = Char.ToUpper(altArray[myS.Length - 1]);
            for (int i = 0; i < altArray.Length; i++)
            {
                if (altArray[i] == ' ')
                {
                    altArray[i - 1] = Char.ToUpper(altArray[i - 1]);
                    altArray[i + 1] = Char.ToUpper(altArray[i + 1]);
                }
            }
            Console.WriteLine(altArray);
        }
        //•	Write a method to compute sum of digits of a given string(if any
        static void ComputeTheSumOfDigits(string myString)
        {
            int sum = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                if (char.IsDigit(myString[i]))
                {
                    int m = int.Parse(Convert.ToString(myString[i])) % 10;
                    sum = sum + m;
                }
            }
            Console.WriteLine("Sum of digits is: " + sum);
        }
    }
}
