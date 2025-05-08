using System;
using System.Collections;
using System.Linq;

public class Solution
{
    public void Print2Arr(IList<IList<int>> arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine($"Array: {string.Join(", ", item)}");
        }
    }

    static void Swap(int[] nums, int i, int j)
    {
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }

    // Helper to generate permutations
    static List<List<int>> GetPermutations(int[] nums)
    {
        var result = new List<List<int>>();
        Permutate(nums, 0, result);
        return result;
    }

    static void Permutate(int[] nums, int start, List<List<int>> result)
    {
        if (start == nums.Length)
        {
            result.Add(new List<int>(nums));
            return;
        }

        for (int i = start; i < nums.Length; i++)
        {
            Swap(nums, start, i);
            Permutate(nums, start + 1, result);
            Swap(nums, start, i); // backtrack
        }
    }

    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        int[] input = { 1, 2, 3 };

        var permutations = GetPermutations(input);

        foreach (var perm in permutations)
        {
            // Check if this permutation already exists in res
            if (!res.Any(existing => existing.SequenceEqual(perm)))
            {
                res.Add(perm.ToList()); // Add unique permutation
            }
        }

        // Log the result
        Print2Arr(res);
      
        return res;
    }

    static void Main()
    {
        Solution solution = new Solution();
        int[] nums = [1, 2, 3];

        solution.Permute(nums);
    }
}
