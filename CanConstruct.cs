/*
    * EXPLANATION
    * How This Works:
    *
    * Use an array charCount[26] to store occurrences of each letter in magazine.
    * Traverse ransomNote:
    * If a letter isn’t available (charCount[c - 'a'] == 0), return false.
    * Otherwise, decrement its count.
    *
    * Return true if all letters are found.
*/

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] charCount = new int[26]; // To store letter frequencies

        // Count frequency of each letter in magazine
        foreach (char c in magazine) {
            charCount[c - 'a']++;
        }

        // Check if ransomNote can be constructed
        foreach (char c in ransomNote) {
            if (charCount[c - 'a'] == 0) {
                return false; // Not enough letters available
            }
            charCount[c - 'a']--; // Use one letter
        }

        return true;
    }

      static void Main() {
        Solution sol = new Solution();
        Console.WriteLine(sol.CanConstruct("aa", "a")); // Should return false
        Console.WriteLine(sol.CanConstruct("aa", "aab")); // Should return true
    }
}
