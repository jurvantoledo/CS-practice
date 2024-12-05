using System;

public class Solution {
    public int FindPeakElement(int[] nums) {
        int idx = 0;
        for (idx = 0; idx < nums.Length - 1; idx++) {
            if (nums[idx] > nums[idx + 1]) {
                break;
            }
        }
        
        return idx;
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {1, 2, 1, 3, 5, 6, 4};
        sol.FindPeakElement(nums);
    }
}
