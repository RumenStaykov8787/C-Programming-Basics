using System;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] sortedArray = SortingNumbers(n);

        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.Write(sortedArray[i] + " ");
        }
        Console.WriteLine();
    }
    static int[] SortingNumbers(int count)
    {
        int[] arrayOfNumbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrayOfNumbers);
        return arrayOfNumbers;
    }
}