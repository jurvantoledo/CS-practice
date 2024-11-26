using System;

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int newIndex = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[newIndex] = nums[i];
                newIndex++;
            }
        }
        
        for (int j = newIndex; j < nums.Length; j++)
        {
            nums[j] = '_';
        }
        return newIndex;
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {0,1,2,2,3,0,4,2};
        
        sol.RemoveElement(nums, 2);
        Console.WriteLine($"[{string.Join(", ", nums)}]");
    }
}