using System;
using System.Linq;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        if (n == 0) return 0;
        
        int writeIdx = 1;
        int count = 1;
        
        for (int i = 1; i < n; i++) {
            if (nums[i] == nums[i - 1]) {
                count++;
            }
            else {
                count = 1;
            }
            
            if (count <= 2) {
                nums[writeIdx] = nums[i];
                writeIdx++;
            }
        }
        
        for (int i = writeIdx; i < nums.Length; i++) {
            nums[i] = -1;
        }
        return writeIdx;
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        int[] nums = new int[] {1,1,1,2,2,3};
        
        sol.RemoveDuplicates(nums);
    }
}
