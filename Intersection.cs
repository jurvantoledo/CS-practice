public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        IEnumerable<int> both = nums1.Intersect(nums2);
        
        int[] res = both.ToArray();
        
        return res;
    }
}
