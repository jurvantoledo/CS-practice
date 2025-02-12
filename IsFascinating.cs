using System;
using System.Collections.Generic;

public class Solution {
    public bool IsFascinating(int n) {
        Dictionary<char, int> dict = new Dictionary<char, int> ();
        int sum2 = 2 * n;
        int sum3 = 3 * n;
        string str = String.Concat(n.ToString(), sum2.ToString(), sum3.ToString());
        
        if (str.Length < 9) {
            return false;
        }
        
        Console.WriteLine($"{n} + {sum2} + {sum3} = {str}");
        for (int i = 0; i < str.Length; i++) {
            if (!dict.ContainsKey(str[i])) {
                dict[str[i]] = 0;
            } 
        }
        
        for (int j = 0; j < str.Length; j++)
        {
            if (dict.ContainsKey(str[j])) dict[str[j]]++;
        }
        
        
        foreach (KeyValuePair<char, int> d in dict) {
            Console.WriteLine($"{d.Key}, {d.Value}");
            
            if (d.Value == 0 || d.Value > 1) return false;
            if (d.Key == '0') return false;
        }
        return true;
    }
    
    static void Main() {
        Solution sol = new Solution();
        
        Console.Write(sol.IsFascinating(267));
    }
}
