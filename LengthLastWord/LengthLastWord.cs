using System;

public class Solution {
    public int LengthOfLastWord(string s) {
        string trimmedStr = s.Trim(' ');
        string[] words = trimmedStr.Split(' ');
        
        Console.WriteLine(words.Length);
        int lastWordInArr = words.Length;
        int lastWordLen = words[lastWordInArr - 1].Length;
        return lastWordLen;
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        Console.Write(sol.LengthOfLastWord("Hello world"));
    }
}