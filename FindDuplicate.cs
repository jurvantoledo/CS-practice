using System;
using System.Collections.Generic;

public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach(int num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }
        }
        
        foreach(var pair in dict) {
            if (pair.Value > 1) {
                Console.WriteLine($"{pair.Key} appears {pair.Value} times");
                return pair.Key;
            }
        }
        return 0;
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {0};
        
        sol.FindDuplicate(nums);
    }
}
