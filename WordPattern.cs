using System;
using System.Collections.Generic;

public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        if (pattern.Length != words.Length) return false; // Must match in length

        Dictionary<char, string> charToWord = new Dictionary<char, string>();
        Dictionary<string, char> wordToChar = new Dictionary<string, char>();

        for (int i = 0; i < pattern.Length; i++) {
            char c = pattern[i];
            string word = words[i];

            if (charToWord.ContainsKey(c)) {
                if (charToWord[c] != word) return false; // Character must always map to the same word
            } else {
                charToWord[c] = word;
            }

            if (wordToChar.ContainsKey(word)) {
                if (wordToChar[word] != c) return false; // Word must always map to the same character
            } else {
                wordToChar[word] = c;
            }
        }

        return true;
    }

    static void Main() {
        Solution sol = new Solution();
        Console.WriteLine(sol.WordPattern("abba", "dog cat cat dog")); // Output: True
        Console.WriteLine(sol.WordPattern("abba", "dog cat cat fish")); // Output: False
        Console.WriteLine(sol.WordPattern("aaaa", "dog cat cat dog")); // Output: False
    }
}
