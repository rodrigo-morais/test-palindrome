using System;

public class Palindrome
{
    private static string removeInvalidCharacters(string str){
        var newStr = "";

        foreach(var word in str){
            if (char.IsLetterOrDigit(word))
            {
                newStr = newStr + word;
            }
        }

        return newStr;
    }

    public static bool IsPalindrome(string str)
    {
        var newStr = "";

        str = str.ToLower();
        str = removeInvalidCharacters(str);

        foreach(var word in str){
            newStr = word.ToString() + newStr;
        }

        return newStr.Equals(str);

    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("Noel sees Leon."));
        Console.WriteLine(IsPalindrome("Sore was I ere I saw Eros."));
        Console.WriteLine(IsPalindrome("Stop! nine myriad murmur. Put up rum, rum, dairymen, in pots."));
        Console.Read();
    }
}