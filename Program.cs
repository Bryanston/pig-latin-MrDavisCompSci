// Console template
using System;
class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.Clear();
        Console.WriteLine("Enter a sentence: ");
        string userInput = Console.ReadLine();

        Console.WriteLine(PigLatinSentence(userInput));
    }

    static string PigLatinWord(string s)
    {
        string result = "";

        // WITCHCRAFT!
        char firstLetter = s[0];
        string restOfWord = s.Substring(1);

        result = restOfWord + firstLetter + "ay";

        return result;
    }

    static string PigLatinSentence(string sentence)
    {
        string result = "";
        string[] sentenceArray = sentence.Split(' ');

        foreach(string word in sentenceArray)
        {
            result = result + PigLatinWord(word) + " ";
        }
        return result;
    }
}
