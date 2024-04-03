using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<List<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates); 
        List<List<int>> result = new List<List<int>>();
        FindCombinations(candidates, target, 0, new List<int>(), result);
        return result;
    }

    static void FindCombinations(int[] candidates, int target, int start, List<int> path, List<List<int>> result)
    {
        if (target == 0) 
        {
            result.Add(new List<int>(path));
            return;
        }
        if (target < 0) 
        {
            return;
        }
        for (int i = start; i < candidates.Length; i++)
        {
   
            if (i > start && candidates[i] == candidates[i - 1])
            {
                continue;
            }
   
            path.Add(candidates[i]);
            FindCombinations(candidates, target - candidates[i], i + 1, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] candidates1 = { 2, 5, 2, 1, 2 };
        int target1 = 5;
        Console.WriteLine("Вывод для первого примера:");
        foreach (var combination in CombinationSum(candidates1, target1))
        {
            Console.WriteLine($"[{string.Join(", ", combination)}]");
        }

        int[] candidates2 = { 10, 1, 2, 7, 6, 1, 5 };
        int target2 = 8;
        Console.WriteLine("\nВывод для второго примера:");
        foreach (var combination in CombinationSum(candidates2, target2))
        {
            Console.WriteLine($"[{string.Join(", ", combination)}]");
        }
    }
}