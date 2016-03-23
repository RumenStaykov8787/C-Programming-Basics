using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> names = input.Split(' ').ToList();

        string namesToBeRemoved = Console.ReadLine();
        List<string> equalNames = namesToBeRemoved.Split(' ').ToList();

        for (int i = 0; i < equalNames.Count; i++) 
        {
            for (int j = 0; j < names.Count; j++)
            {
                if (names.Contains(equalNames[i]))
                {
                    names.Remove(equalNames[i]);
                }
            }
        }

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine(string.Join<string>(" ", names));
    }
}