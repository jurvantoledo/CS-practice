using System;

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        try {
            int[] sortedNumsArr = new int[m + n];
            int idx = 0;
            for (idx = 0; idx < m; idx++) {
                sortedNumsArr[idx] = nums1[idx];
            }
            for (int j = 0; j < n; j++) {
                sortedNumsArr[idx] = nums2[j];
                idx++;
            }
            int temp = 0;
            for (int k = 0; k < sortedNumsArr.Length - 1; k++)
            {
                for (int t = 0; t < sortedNumsArr.Length - k - 1; t++) {
                    if (sortedNumsArr[t] > sortedNumsArr[t + 1])
                    {
                        temp = sortedNumsArr[t];
                        sortedNumsArr[t] = sortedNumsArr[t + 1];
                        sortedNumsArr[t + 1] = temp;
                    }
                }

            }
            for (int x = 0; x < sortedNumsArr.Length; x++) {
                nums1[x] = sortedNumsArr[x];
            }
            
        } catch (IndexOutOfRangeException e)
        {
            if (m == 0) {
                for (int i = 0; i < n; i++) {
                    nums1[i] = nums2[i];
                }
            }
        }
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums1 = new int[] {4,5,6,0,0,0};
        int[] nums2 = new int[] {1,2,3};
        
        
        sol.Merge(nums1, 3, nums2, 3);
        Console.WriteLine($"Main: [{string.Join(",", nums1)}]");
    }
}
