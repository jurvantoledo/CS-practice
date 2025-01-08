using System;
using System.Linq;

public class Solution {
    public int AddDigits(int num) {
        if (num < 10) return num;
        
        int value = num
                    .ToString()
                    .Select(digit => int.Parse(digit.ToString()))
                    .Sum();

        return AddDigits(value);
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        Console.WriteLine($"{sol.AddDigits(38)}");
    }
}
