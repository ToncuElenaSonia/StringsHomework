using System;

namespace CleanTheText
{
    class Program
    {
        static void Main(string[] args)
        {
            string myThirdString = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
            string removeSTrangeChars = "^<> &+ @%$";
            DirtyString(myThirdString, removeSTrangeChars);

            Console.WriteLine("Please enter the text for _ing and _ly: ");
            string mySecondString = Console.ReadLine();
            IngString(mySecondString);

            Console.WriteLine("The obfucate email is: ");
            string myObfucateEmail = "awesome@dotnet.com";
            ObfucateEmail(myObfucateEmail);

            Console.WriteLine("Please introduce the text for re-string: ");
            string restring = Console.ReadLine();
            Console.WriteLine(nTwice(restring));

            Console.WriteLine("Enter the string that will be changed with $: ");
            string myReplaceString = Console.ReadLine();
            ReplaceChar(myReplaceString);

            SwapMethod();

            string s = "The lyrics is not that poor!";
            FirstAppeareance(s);

            Console.WriteLine("Enter the string: ");
            string myNewString = Console.ReadLine();
            FindLongestWord(myNewString);

        }
        // You will get a text from where you will need to clean the text because it contains 
        //a lot of strange characters that don’t belong there( ^ <, > &+ @%$)
        //Output:Hi there I’m telling you, you need to do your homeworks. Hate me now and thank me later.
        static void DirtyString(string strangeString, string removeStrangeChars)
        {
            char[] myArray = removeStrangeChars.ToCharArray();
            string result = strangeString;
            foreach (char c in myArray)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (c == result[i])
                    {
                        result = result.Replace(result[i], ' ');
                    }
                }
            }
            Console.WriteLine(result);
        }
        // !!!REFACUTA!!!! Write a method to add 'ing' at the end of a given string (length should be at least 3). 
        //If the given string already ends with 'ing' then add 'ly' instead.If the string length of the 
        //given string is less than 3, leave it unchanged.

        //Input : 'abc'
        //Output:'abcing' 
        //Input : 'string'
        //Output: 'stringly'
        static void IngString(string myString)
        {
            if (myString.Length >= 3)
            {
                if (myString.Trim().EndsWith("ing"))
                {
                    myString += "ly";
                    Console.WriteLine($"The new string with 'ly' is:{myString}");
                }
                else
                {
                    myString += "ing";
                    Console.WriteLine($"The new string with 'ing' is:{myString}");
                }
            }
            else
            {
                Console.WriteLine($"The unchaged string is:{myString}");

            }
        }
        //You have some text that contains your email address. And you want to hide that. You 
        //decide to censor your email: to replace all characters in it with asterisks ('*') except the 
        //domain. Assume your email address will always be in format [username]@[domain]. You 
        //need to replace the username with asterisks of equal number of letters and keep the 
        //domain unchanged. You will get as input the email address you need to obfuscate

        //Input: awesome @dotnet.com
        //Output: *******@dotnet.com
        static void ObfucateEmail(string myEmail)
        {
            char[] myArray = myEmail.ToCharArray();
            string myNewEmail = myEmail;
            var output = "";
            var n = myNewEmail.IndexOf('@');


            for (int i = 0; i < n; i++)
            {
                if (myArray[i] != '@')
                {
                    output = output + "*";
                }
            }
            Console.WriteLine($"{output}{myNewEmail.Substring(n)}");
        }
        //Write a method to get a string made of the first 2 and the last 2 chars from a given a string. 
        //If the string length is less than 2, return instead of the empty string.
        static string nTwice(string str)
        {
            string reString = str;
            if (str.Length < 2)
            {
                return reString = "";
            }
            else
            {
                if (str.Length == 2)
                {
                    return ($"{reString}{reString}");
                }
                else
                {
                    return (str.Substring(0, 2) + str.Substring(str.Length - 2));
                }
            }
        }
        // Write a method to get a string from a given string where all 
        //occurrences of its first char have been changed to '$', except the first char itself.

        // Sample String : 'restart'
        //Expected Result : 'resta$t'
        static void ReplaceChar(string myString1)
        {
            string myString = myString1;
            for (int i = 1; i < myString.Length; i++)
            {
                if (myString[i] == myString[0])
                {
                    myString = myString.Insert(i, "$");
                    myString = myString.Remove(i + 1, 1);
                }
            }
            Console.WriteLine(myString);
        }
        //•	Write a method to get a single string from two given strings, 
        //separated by a space and swap the first two characters of each string.

        //Input: 'abc', 'xyz' 
        // Output: 'xyc abz'
        static void SwapMethod()
        {
            string str1 = "abc";
            string str2 = "xyz";
            string str3 = "";
            str3 = str1 + " " + str2;
            char[] array2 = str3.ToCharArray();
            char c = array2[0];
            char d = array2[1];
            for (int i = 1; i < array2.Length; i++)
            {
                if (array2[i] == ' ')
                {
                    char e = array2[i + 1];
                    char f = array2[i + 2];
                    array2[0] = e;
                    array2[1] = f;
                    array2[i + 1] = c;
                    array2[i + 2] = d;
                    break;
                }
            }
            Console.WriteLine($"The string that is created from two strings is:{new String(array2)}");
        }
        //•	Write a method to find the first appearance of the substring 'not' and 'poor' from 
        //a given string, if 'not' follows the 'poor', replace the whole 'not'...'poor' substring 
        //with 'good'. Return the resulting string.

        //Input: 'The lyrics is not that poor!'
        // Output : 'The lyrics is poor!'
        static void FirstAppeareance(string str)
        {
            string str1 = "good";
            string stringForGood = str;
            int positionNot = str.IndexOf("not");
            Console.WriteLine($"The first appearance of the substring 'not' is:{positionNot}");
            int positionPoor = str.IndexOf("poor");
            Console.WriteLine($"The first appearance of the substring 'poor' is:{positionPoor}");
            string[] AppearanceString = str.Split(' ');
            string stringBetweenNotAndPoor = str.Substring(positionNot, positionPoor - positionNot);
            Console.WriteLine($"Substringul intre cele doua pozitii este:{stringBetweenNotAndPoor}");
            foreach (var position in AppearanceString)
            {
                if (positionNot < positionPoor)
                {
                    stringForGood = stringForGood.Replace(stringBetweenNotAndPoor, "");
                }
            }
            Console.WriteLine($"Daca 'not' este dupa 'poor', noul string este:{stringForGood}");
            Console.WriteLine($"Noul string dupa replace 'poor' cu 'good' este:{stringForGood.Replace(str.Substring(positionPoor), str1) + stringForGood.Substring(stringForGood.Length - 1, 1)}");
        }
        //Write a method that takes a list of words and returns the length of the longest one.
        static void FindLongestWord(string inputString)
        {
            string largest = "";
            string[] myArray = inputString.Split(' ');

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Length > largest.Length)
                {
                    largest = myArray[i];
                }
            }
            Console.WriteLine($"The longest word is: {largest}");
            char[] myLargestArray = largest.ToCharArray();
            int count = 0;
            foreach (var item in myLargestArray)
            {
                count++;
            }
            Console.WriteLine($"Number of characters of the largest word is: {count}");
        }
    }
}
