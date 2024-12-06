using System;

public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0) return -1;
        int idx = 0;
        
        for (idx = 0; idx < nums.Length; idx++) {
            if (nums[idx] == target) break;
        }
        
        if (idx == nums.Length) {
            return -1;
        }
        
        return idx;
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {1};
        
        Console.Write(sol.Search(nums, 1));
    }
}
