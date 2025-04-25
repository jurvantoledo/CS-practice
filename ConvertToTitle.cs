using System;

public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string columnLetter = string.Empty;
        while (columnNumber > 0)
        {
            columnNumber--;
            columnLetter = (char)(columnNumber % 26 + 65) + columnLetter;
            columnNumber /= 26;
        }
        return columnLetter;
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        Console.Write(sol.ConvertToTitle(701));
    }
}
