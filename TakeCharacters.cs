using System;

public class Solution
{
    public int TakeCharacters(string s, int k) {
        int totalA = 0, totalB = 0, totalC = 0;
        foreach (char c in s) {
            if (c == 'a') totalA++;
            else if (c == 'b') totalB++;
            else if (c == 'c') totalC++;
        }

        if (totalA < k || totalB < k || totalC < k) {
            return -1;
        }

        int n = s.Length;
        int left = 0, maxLength = 0;
        int[] count = { 0, 0, 0 };

        for (int right = 0; right < n; right++) {
            if (s[right] == 'a') count[0]++;
            else if (s[right] == 'b') count[1]++;
            else if (s[right] == 'c') count[2]++;

            while (totalA - count[0] < k || totalB - count[1] < k || totalC - count[2] < k) {
                if (s[left] == 'a') count[0]--;
                else if (s[left] == 'b') count[1]--;
                else if (s[left] == 'c') count[2]--;
                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return n - maxLength;
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        Console.Write(sol.TakeCharacters("a", 0));
    }
}
