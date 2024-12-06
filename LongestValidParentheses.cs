using System;
using System.Collections;

public class Solution {
    public int LongestValidParentheses(string s) {
        Stack myStack = new Stack();
        int maxLen = 0;

        myStack.Push(-1);

        for (int idx = 0; idx < s.Length; idx++) {
            if (s[idx] == '(') {
                myStack.Push(idx);
            } else {
                myStack.Pop();
                
                if (myStack.Count == 0) {
                    myStack.Push(idx);
                } else {
                    maxLen = Math.Max(maxLen, idx - (int)myStack.Peek());
                }
            }
        }
        return maxLen;
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        sol.LongestValidParentheses("(()");
    }
}
