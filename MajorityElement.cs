using System;
using System.Collections.Generic;


public class Solution {
    public int MajorityElement(int[] nums) {
        if (nums.Length < 1) return 0;
        
        Dictionary<int, int> amount = new Dictionary<int, int>();
        int i = 0;
        Console.WriteLine(string.Join(", ", nums));
        
        foreach (int num in nums) {
            if (amount.ContainsKey(num)) {
                amount[num]++;
            } else {
                amount.Add(num, 0);
            }
        }
        
        int res = 0;
        int maxVal = int.MinValue;
        
        foreach (var kpv in amount) {
            Console.WriteLine($"{kpv.Key}, {kpv.Value}");
            
            if (kpv.Value > maxVal) {
                maxVal = kpv.Value;
                res = kpv.Key;
            }
        }
        
        return res;
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = {3, 2, 3, 4, 4, 4};
        
        Console.Write(sol.MajorityElement(nums));
    }
}
