using System;

public class Solution {
    public bool IsPalindrome(int x) {
        string str = Convert.ToString(x);
        char[] strArray = str.ToCharArray();
        Array.Reverse(strArray);
        string reversedStr = new string(strArray);
        
        bool result = str.Equals(reversedStr);
        return result;
    }
    
    static void Main() {
        Solution solution = new Solution();
        
        bool isPalindrome = solution.IsPalindrome(121);
        Console.WriteLine($"Is 121 a palindrome? {isPalindrome}");
    }
}