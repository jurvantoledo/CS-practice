using System;
using System.Collections.Generic;

public class Solution {
    public int[] SingleNumber(int[] nums) {
       Dictionary<int, int> dict = new Dictionary<int, int>();
        int i = 0;
        int idx = 0;
        int[] res = new int[2];
        foreach(int num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }
        }
        
        foreach(KeyValuePair<int, int> kvp in dict)
        {
            if (kvp.Value == 1) {
                res[idx] = kvp.Key;
                idx++;
            }
        }
        
        return res;
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {0};
        sol.SingleNumber(nums);
    }
}
