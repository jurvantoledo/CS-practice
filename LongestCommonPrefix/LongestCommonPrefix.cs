using System;

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Console.WriteLine(string.Join(", ", strs)); // This will print the array elements
        return ""; // Placeholder return
    }
    
    static void Main() {
        Solution sol = new Solution();
        sol.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
    }
}