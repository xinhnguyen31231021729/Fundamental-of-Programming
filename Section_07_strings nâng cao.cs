using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

internal class Program
{

/*▸Write a program in C# Sharp
- to input a string and print it.
- to find the length of a string without using a library function.
- to separate individual characters from a string.
- to print individual characters of the string in reverse order.
- to count the total number of words in a string.
- to compare two strings without using a string library functions.
- to count the number of alphabets, digits and special characters in a string.
- to count the number of vowels or consonants in a string.
- to check whether a given substring is present in the given string.
- to search for the position of a substring within a string.
- to check whether a character is an alphabet and not and if so, check for the case.
- to find the number of times a substring appears in a given string.
- to insert a substring before the first occurrence of a string.
*/
    static void Main(string[] args)
    {
        //Write a program in C# Sharp:
        //baitap_01();
        //baitap_02();
        //baitap_03();
        //baitap_04();
        //baitap_05();
        //baitap_06();
        //baitap_07();
        //baitap_08();
        //baitap_09();
        //baitap_10();
        //baitap_11();

    }

    static void baitap_01() // to input a string and print it.
    {
        Console.WriteLine("Input a string: ");
        string UserInput = Console.ReadLine();
        Console.WriteLine("Output a string: {0}", UserInput);
    }

    static void baitap_02() // to find the length of a string without using a library function.
    {
        Console.WriteLine("Enter a string: ");
        string User_Input = Console.ReadLine();
        int length = 0;
        foreach (char c in User_Input)
        {
            length++;
        }
        Console.WriteLine("The length of the string is: {0}", length);
    }

    static void baitap_03() // to separate individual characters from a string.
    {
        Console.WriteLine("Enter a string: ");
        string User_Input = Console.ReadLine();
        Console.WriteLine("The individual characters in the string are: ");
        
        foreach (char c in User_Input)
        {
            Console.WriteLine(c);
        }
    }

    static void baitap_04() // to print individual characters of the string in reverse order.
    {
        Console.WriteLine("Enter a string: ");
        string User_Input = Console.ReadLine();
        Console.WriteLine("The individual characters of the string in reverse order are: ");

        for (int i = User_Input.Length - 1; i >= 0; i--) 
        {
            Console.WriteLine(User_Input[i]);
        }

    }

    static void baitap_05() // to count the total number of words in a string.
    {
        Console.WriteLine("Enter a string: ");
        string User_Input = Console.ReadLine();
        string[] words = User_Input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int wordcount = words.Length;
        Console.WriteLine("The total number of words in the string is: {0}", wordcount);
    }

    static void baitap_06() //to compare two strings without using a string library functions.
    {
        Console.WriteLine("Enter thr 1st string: ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the 2nd string: ");
        string str2 = Console.ReadLine();
        bool areEqual = CompareStrings(str1, str2);
        if (areEqual)
        {
            Console.WriteLine("The 2 strings are equal");
        }
        else
        {
            Console.WriteLine("The 2 strings are not equal");
        }
    }

    static bool CompareStrings(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            { return false; }
        }
        return true;
    }

    static void baitap_07() //to count the number of alphabets, digits and special characters in a string.
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        // Variables to store counts of alphabets, digits, and special characters
        int alphabetCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;

        // Loop through each character in the string
        foreach (char c in userInput)
        {
            if (char.IsLetter(c))
            {
                alphabetCount++; // If the character is an alphabet
            }
            else if (char.IsDigit(c))
            {
                digitCount++; // If the character is a digit
            }
            else
            {
                specialCharCount++; // Otherwise, it's a special character
            }
        }

        // Display the counts
        Console.WriteLine("Number of Alphabets: " + alphabetCount);
        Console.WriteLine("Number of Digits: " + digitCount);
        Console.WriteLine("Number of Special Characters: " + specialCharCount);
    }

    static void baitap_08() //to count the number of vowels or consonants in a string.
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        // Convert the string to lowercase to handle both upper and lower case letters
        userInput = userInput.ToLower();

        // Variables to store counts of vowels and consonants
        int vowelCount = 0;
        int consonantCount = 0;

        // Define the vowels
        string vowels = "aeiou";

        // Loop through each character in the string
        foreach (char c in userInput)
        {
            if (char.IsLetter(c))  // Check if it's a letter
            {
                if (vowels.Contains(c)) // Check if the letter is a vowel
                {
                    vowelCount++;
                }
                else // If it's not a vowel, it must be a consonant
                {
                    consonantCount++;
                }
            }
        }

        // Display the counts
        Console.WriteLine("Number of Vowels: " + vowelCount);
        Console.WriteLine("Number of Consonants: " + consonantCount);
    }

    static void baitap_09()
    {
        // Prompt the user to enter the main string
        Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();

        // Prompt the user to enter the substring
        Console.Write("Enter the substring: ");
        string substring = Console.ReadLine();

        // Check if the substring is present in the main string
        bool isSubstringPresent = CheckSubstring(mainString, substring);

        // Output the result
        if (isSubstringPresent)
        {
            Console.WriteLine("The substring is present in the main string.");
        }
        else
        {
            Console.WriteLine("The substring is not present in the main string.");
        }
    }

    // Method to check if the substring is present in the main string
    static bool CheckSubstring(string mainString, string substring)
    {
        int mainLength = mainString.Length;
        int subLength = substring.Length;

        // Traverse the main string and check if any part matches the substring
        for (int i = 0; i <= mainLength - subLength; i++)
        {
            int j;
            for (j = 0; j < subLength; j++)
            {
                if (mainString[i + j] != substring[j])
                {
                    break; // Break if characters do not match
                }
            }
            if (j == subLength)
            {
                return true; // Return true if the substring is found
            }
        }

        return false; // Return false if the substring is not found
    }

    static void baitap_10() //to search for the position of a substring within a string.
    {
        // Prompt the user to enter the main string
        Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();

        // Prompt the user to enter the substring
        Console.Write("Enter the substring to search for: ");
        string substring = Console.ReadLine();

        // Get the position of the substring within the main string
        int position = FindSubstringPosition(mainString, substring);

        // Output the result
        if (position != -1)
        {
            Console.WriteLine($"The substring starts at position {position}.");
        }
        else
        {
            Console.WriteLine("The substring is not found in the main string.");
        }
    }

    // Method to find the position of the substring within the main string
    static int FindSubstringPosition(string mainString, string substring)
    {
        int mainLength = mainString.Length;
        int subLength = substring.Length;

        // Traverse the main string to check if any part matches the substring
        for (int i = 0; i <= mainLength - subLength; i++)
        {
            int j;
            for (j = 0; j < subLength; j++)
            {
                if (mainString[i + j] != substring[j])
                {
                    break; // Break if characters do not match
                }
            }
            if (j == subLength)
            {
                return i; // Return the starting index if substring is found
            }
        }

        return -1; // Return -1 if the substring is not found
    }

    static void baitap_11()
    {
        // Prompt the user to enter a character
        Console.Write("Enter a character: ");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Check if the character is an alphabet
        if (IsAlphabet(inputChar))
        {
            // Check if it's uppercase or lowercase
            if (char.IsUpper(inputChar))
            {
                Console.WriteLine($"{inputChar} is an uppercase letter.");
            }
            else if (char.IsLower(inputChar))
            {
                Console.WriteLine($"{inputChar} is a lowercase letter.");
            }
        }
        else
        {
            Console.WriteLine($"{inputChar} is not an alphabet character.");
        }
    }

    // Method to check if the character is an alphabet
    static bool IsAlphabet(char c)
    {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }

}
