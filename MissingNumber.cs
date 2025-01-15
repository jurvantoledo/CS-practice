using System;

public class Solution {
    public int MissingNumber(int[] nums) {
        int[] arr = new int[nums.Length + 1];
        Array.Sort(nums);
        int res = 0;
        
        
        for (int i = 0; i < nums.Length + 1; i++) {
            arr[i] = i;
        }
        
        
        for (int i = 0; i < arr.Length; i++) {
            if (i >= nums.Length || nums[i] != arr[i]) {
                return arr[i];
            }
        }
        
        return 0;
    }
    
    static void Main() {
        Solution sol = new Solution();
        int[] nums = new int[] {1, 2};
        Console.WriteLine($"{sol.MissingNumber(nums)}");
    }
}

// using System;

// public class Solution {
//     public int MissingNumber(int[] nums) {
//         int n = nums.Length;
//         int expectedSum = n * (n + 1) / 2;
//         int actualSum = 0;
        
//         foreach (int num in nums) {
//             actualSum += num;
//         }
        
//         return expectedSum - actualSum;
//     }
    
//     static void Main() {
//         Solution sol = new Solution();
//         int[] nums = new int[] {1, 2};
//         Console.WriteLine($"{sol.MissingNumber(nums)}");
//     }
// }
