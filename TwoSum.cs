using System;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Console.WriteLine($"Array: [{string.Join(", ", nums)}], Target: {target}");
        int[] newArray = new int[2];
        int test = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"I: {nums[i]}");
            for (int j = i + 1; j < nums.Length; j++) // Start j from i + 1 to avoid pairing the same element
            {
                Console.WriteLine($"J: {nums[j]}");
                test = nums[i] + nums[j];
                Console.WriteLine(test);
                
                if (test == target)
                {
                    newArray[0] = i;
                    newArray[1] = j;
                    break;
                }
            }
            if (test == target)
            {
                break;
            }
        }
        
        Console.WriteLine($"Result Indices: [{string.Join(", ", newArray)}]");
        return newArray;
    }

    static void Main() {
        Solution solution = new Solution();
        
        // Store the result of TwoSum in a variable and print it
        int[] result = solution.TwoSum(new int[] { 12, 2, 7, 15 }, 9);
        Console.WriteLine($"Output Indices: [{string.Join(", ", result)}]");
    }
}