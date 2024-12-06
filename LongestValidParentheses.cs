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

// EXPLANATION:
// Example 1: "(()"
// Stack initially: [-1]
// '(' at index 0 → Push index 0. Stack: [-1, 0]
// '(' at index 1 → Push index 1. Stack: [-1, 0, 1]
// ')' at index 2 → Pop index 1. Stack: [-1, 0]
// Valid substring length = 2 - 0 = 2.
// Final maxLen = 2.

// Example 2: "()(()"
// Stack initially: [-1]
// '(' at index 0 → Push index 0. Stack: [-1, 0]
// ')' at index 1 → Pop index 0. Stack: [-1]
// Valid substring length = 1 - (-1) = 2.
// '(' at index 2 → Push index 2. Stack: [-1, 2]
// '(' at index 3 → Push index 3. Stack: [-1, 2, 3]
// ')' at index 4 → Pop index 3. Stack: [-1, 2]
// Valid substring length = 4 - 2 = 2.
// Final maxLen = 2.
