// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class Solution {
   // Wrong implementation still okay answer
    public int[] SearchRange2(int[] nums, int target) {
        if (nums.Length == 0) return new int[2] {-1, -1};
        
        int[] newNums = new int[nums.Length];
        int idx = 0;
        int len = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == target) {
                newNums[len] = idx;
                len++;
            }
            idx++;
        }

        int[] result = newNums;
        
        result = result.Where((val, index) => index < len).ToArray();
        
        if (result.Length == 0) return new int[2] {-1, -1};
        

        return result;
    }

    // Right implementation, good (and easy) answer
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length == 0) return new int[] { -1, -1 };
        
        int start = -1;
        int end = -1;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == target) {
                if (start == -1) start = i;
                end = i;
            }
        }

        return new int[] { start, end };
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {1};
        
        Console.WriteLine($"[{string.Join(",", sol.SearchRange(nums, 1))}]");
    }
}
