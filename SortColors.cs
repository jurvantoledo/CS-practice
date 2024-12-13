using System;

public class Solution {
    public void SortColors(int[] nums) {
        int temp = 0;
        for (int i = 0; i < nums.Length - 1; i++) {
            for (int j = 0; j < nums.Length - 1 - i; j++) {
                if (nums[j] > nums[j + 1]) {
                    temp = nums[j]; // 2
                    nums[j] = nums[j + 1]; // 2 -> 0
                    nums[j + 1] = temp; // 0 -> 2
                }
            }
        }
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {};
        
        sol.SortColors(nums);

    }
}
