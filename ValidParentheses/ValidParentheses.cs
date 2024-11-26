using System;
using System.Collections;

public class Solution {
    public bool IsValid(string s) {
        Stack myStack = new Stack();
        
        foreach(char bracket in s)
        {
            if (bracket == '(' || bracket == '[' || bracket == '{') {
                myStack.Push(bracket);
            }
            else {
                if (myStack.Count == 0) {
                    return false;
                }
                if (bracket == '}' && (char)myStack.Peek() == '{' || bracket == ')' && (char)myStack.Peek() == '(' || bracket == ']' && (char)myStack.Peek() == '[')
                {
                    myStack.Pop();
                } else {
                    return false;
                }
            }
        }
        
        if (myStack.Count > 0)
        {
            return false;
        }
    
        return true;
    }
    
    static void Main() {
        Solution solution = new Solution();
        
        Console.WriteLine(solution.IsValid("(])"));
    }
}
