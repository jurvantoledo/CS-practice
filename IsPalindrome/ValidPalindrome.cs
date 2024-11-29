using System;
using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
        
        char[] charArr = s.ToCharArray();
        Array.Reverse(charArr);

        string newStr = new string(charArr);

        return s.Equals(newStr);
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        Console.Write(sol.IsPalindrome("A man, a plan, a canal: Panama"));
    }
}
