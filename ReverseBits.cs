using System;

public class Solution {
    public uint reverseBits(uint n) {
        // Padding to 32 Bits: The PadLeft(32, '0') ensures that the binary string has a consistent length of 32 bits, which is necessary when dealing with uint
        string binary = Convert.ToString(n, 2).PadLeft(32, '0');
        
        char[] charArray = binary.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        
        // Conversion with Base 2
        uint result = Convert.ToUInt32(reversed, 2);
        return result;
    }
    
    static void Main() {
        Solution sol = new Solution();
        string binaryString = "00000010100101000001111010011100";
        uint n = Convert.ToUInt32(binaryString, 2);
        
        Console.Write(sol.reverseBits(n));
    }
}
