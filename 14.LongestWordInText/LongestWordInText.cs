using System;

class LongestWordInText
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

        int longestWordLenght = 0;
        string word = null;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWordLenght)
            {
                word = words[i];
                longestWordLenght = words[i].Length;
            }
        }

        Console.WriteLine(word);
    }
}