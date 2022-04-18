public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] output = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length; i++)
        {
            output[i] = nums[i];
            output[i + nums.Length] = nums[i];
        }

        return output;
    }
}
