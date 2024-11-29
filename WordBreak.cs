// Wrong anwser still wanna save!

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        List<string> words = new List<string>();
        int idx = 0;
        

        while (idx < s.Length) {
            bool found = false;
            foreach (string item in wordDict) {
                if (idx + item.Length <= s.Length) {
                    string sub = s.Substring(idx, item.Length);
                    if (sub == item) {
                        words.Add(sub);
                        idx += item.Length;
                        found = true;
                        break;
                    }
                }
            }
            
            if (!found) break;
        }
        
        return idx == s.Length;
    }
    
    static void Main() {
        Solution sol = new Solution();
        List<string> wordDict = new List<string> { "cats", "and", "dog" };

        bool result = sol.WordBreak("catsanddog", wordDict);
    }
}
