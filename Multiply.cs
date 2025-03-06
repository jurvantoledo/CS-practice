using System;
using System.Numerics;

public class Solution {
    public string Multiply(string num1, string num2) {
        try {
            BigInteger x = BigInteger.Parse(num1);
            BigInteger y = BigInteger.Parse(num2);
            
            BigInteger calc = x * y;
            
            return calc.ToString();
        } catch(Exception e) {
            Console.WriteLine(e.Message);
        }
        return null;
    }
    
    public static void Main() {
        Solution sol = new Solution();
        
        sol.Multiply("498828660196", "167141802233061013023557397451289113296441069");
    }
}
