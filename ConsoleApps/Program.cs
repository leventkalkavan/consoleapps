using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 1, 3, 4, 4, 2, 5, 6, 7, 8, 9, 9 };

        var varElements = array.GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key);

        Console.WriteLine("Tekrar eden elemanlar:");
        foreach (int element in varElements)
        {
            string numText = GetNumberText(element);
            Console.WriteLine(numText);
        }

        Console.ReadLine();
    }

    static string GetNumberText(int number)
    {
        switch (number)
        {
            case 1:
                return "championss";
            case 4:
                return "fener";
            case 9:
                return "bahce";
            default:
                return number.ToString();
        }
    }
}