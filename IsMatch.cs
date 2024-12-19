using System;

public class Solution {
    public bool IsMatch(string s, string p) {
        int sIndex = 0, pIndex = 0, starIndex = -1, matchIndex = 0;

        while (sIndex < s.Length)
        {
            if (pIndex < p.Length && (s[sIndex] == p[pIndex] || p[pIndex] == '?'))
            {
                sIndex++;
                pIndex++;
            }
            else if (pIndex < p.Length && p[pIndex] == '*')
            {
                starIndex = pIndex;
                matchIndex = sIndex;
                pIndex++;
            }
            else if (starIndex != -1)
            {
                pIndex = starIndex + 1;
                matchIndex++;
                sIndex = matchIndex;
            }
            else
            {
                return false;
            }
        }

        while (pIndex < p.Length && p[pIndex] == '*')
        {
            pIndex++;
        }

        return pIndex == p.Length;
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        Console.Write(sol.IsMatch("adceb", "*a*b"));
    }
}
