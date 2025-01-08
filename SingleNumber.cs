using System;
using System.Collections.Generic;

public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        
        foreach (int num in nums) {
            if (counts.ContainsKey(num)) {
                // If key is found again increment value
                counts[num]++;
            } else {
                // Adding the key and set the value to 1
                counts[num] = 1;
            }
        }
        
        foreach(KeyValuePair<int, int> kvp in counts)
        {
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
        
        foreach (var kvp in counts) {
            if (kvp.Value == 1) {
                Console.Write(kvp.Key);
                return kvp.Key;
            }
        }
        return 0;
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {2, 2, 3, 2};
        
        sol.SingleNumber(nums);
    }
}
