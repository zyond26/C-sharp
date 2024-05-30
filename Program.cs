using System;

namespace Work_with_strings
{
    class Program
    {
        // Method to reverse a string
        
        public static string ReverseString(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return inputString;
            }

            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Method to count the number of occurrences of a substring within a string
        
        public static int CountOccurrences(string inputString, string searchString)
        {
            if (string.IsNullOrEmpty(inputString) || string.IsNullOrEmpty(searchString))
            {
                return 0;
            }

            int count = 0;
            int index = 0;

            while ((index = inputString.IndexOf(searchString, index, StringComparison.Ordinal)) != -1)
            {
                count++;
                index += searchString.Length;
            }

            return count;
        }

        // Method to replace all occurrences of oldSubstring with newSubstring in inputString
        
        public static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            if (string.IsNullOrEmpty(inputString) || string.IsNullOrEmpty(oldSubstring) || newSubstring == null)
            {
                return inputString;
            }

            return inputString.Replace(oldSubstring, newSubstring);
        }

        // Method to remove all whitespace characters from a string
        
        public static string RemoveWhitespace(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return inputString;
            }

            return string.Concat(inputString.Where(c => !char.IsWhiteSpace(c)));
        }

        static void Main(string[] args)
        {
            // ReverseString
            
            Console.Write("Enter a string : ");
            string userInput = Console.ReadLine();
            string reversedString = ReverseString(userInput);
            Console.WriteLine("Reversed string: " + reversedString);

            // CountOccurrences
            
            Console.Write("Enter the string to search for: ");
            string searchString = Console.ReadLine();
            int count = CountOccurrences(userInput, searchString);
            Console.WriteLine($"The string '{searchString}' occurs {count} times in the string '{userInput}'.");

            // ReplaceSubstring
            
            Console.Write("Enter the original string: ");
            string inputStringForReplace = Console.ReadLine();
            Console.Write("Enter the substring to be replaced: ");
            string oldSubstring = Console.ReadLine();
            Console.Write("Enter the new substring: ");
            string newSubstring = Console.ReadLine();
            string replacedString = ReplaceSubstring(inputStringForReplace, oldSubstring, newSubstring);
            Console.WriteLine("Modified string: " + replacedString);

            // RemoveWhitespace
            
            string stringWithoutWhitespace = RemoveWhitespace(userInput);
            Console.WriteLine("String without whitespace: " + stringWithoutWhitespace);
        }
    }
}
