public class Solution {
    public int ArrayPairSum(int[] nums) {
        int result = 0;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                result += nums[i];
            }
        }

        return result;
    }
}
