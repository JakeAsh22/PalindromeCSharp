using System;
using System.Collections.Generic;

public class Palindrome
{
    public char[] Checker;
    public char[] CheckerFlip;

    public Palindrome (char[] checker, char[] checkerFlip)
    {
        Checker = checker;
        CheckerFlip = checkerFlip;
    }

    public bool PalinCheck()
    {
        for (int i = 0; i<Checker.Length;i++)
        {
            if (Checker[i]!= CheckerFlip[i])
            {
                return false;
            }         
        }
        return true;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter the word/phrase/number to see if it is a palindrome");
        string word = Console.ReadLine();
        char[] wordSplit = word.ToCharArray();
        char[] arrayFlip = word.ToCharArray();
        Array.Reverse(arrayFlip);
        Palindrome palinCheker = new Palindrome(wordSplit, arrayFlip);
        Console.WriteLine(palinCheker.PalinCheck());
    
    }
}