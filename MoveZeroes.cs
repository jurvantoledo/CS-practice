public class Solution {
    public void MoveZeroes(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            int temp = 0;
            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] == 0) {
                    temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
               }
            }
        }
    }
}
