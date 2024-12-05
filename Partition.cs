public class Solution {
    private bool IsPalindrome(string s, int start, int end) {
        while (start < end) {
            if (s[start] != s[end]) return false;
            start++;
            end--;
        }
        return true;
    }

    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> result = new List<IList<string>>();
        IList<string> currentPart = new List<string>();
        
        PartitionHelper(s, 0, currentPart, result);
        
        foreach (var res in result) {
            Console.WriteLine($"[{string.Join(", ", res)}]");
        }
        
        return result;
    }

    private void PartitionHelper(string s, int start, IList<string> currentPart, IList<IList<string>> result) {
        if (start >= s.Length) {
            result.Add(new List<string>(currentPart));
            return;
        }
        
        for (int end = start; end < s.Length; end++) {
            if (IsPalindrome(s, start, end)) {
                currentPart.Add(s.Substring(start, end - start + 1));
                
                PartitionHelper(s, end + 1, currentPart, result);
                
                currentPart.RemoveAt(currentPart.Count - 1);
            }
        }
    }
  
    static void Main() {
        Solution sol = new Solution();
        
        sol.Partition("aab");
    }
}
