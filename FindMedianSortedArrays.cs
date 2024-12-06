using System;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        int len = m + n;
        int[] mergedArray = new int[len];
        
        int i = 0, j = 0, k = 0;
        
        while (i < m && j < n) {
            if (nums1[i] < nums2[j]) {
                mergedArray[k++] = nums1[i++];
            }
            else {
              mergedArray[k++] = nums2[j++];
            }
        }
        
        while (i < m) {
            mergedArray[k++] = nums1[i++];
        }
        
        while (j < n) {
            mergedArray[k++] = nums2[j++];
        }
        
        if (len % 2 == 0) {
            return (mergedArray[len / 2 - 1] + mergedArray[len / 2]) / 2.0;
        }
        
        return mergedArray[len / 2];
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums1 = new int[] {1, 2};
        int[] nums2 = new int[] {3, 4};
        
        Console.WriteLine($"{sol.FindMedianSortedArrays(nums1, nums2)}");
    }
}
