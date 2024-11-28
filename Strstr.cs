public class Solution {
    public int StrStr(string haystack, string needle) {
        if (haystack.Length == 0 || needle.Length == 0) {
            return -1;
        }
        
        if (haystack.Length < needle.Length) {
            return -1;
        }
        
        int index = haystack.IndexOf(needle);

        return index;
    }
}
