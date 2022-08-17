public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Array.IndexOf(nums, nums[i] + diff);

                if (index > -1 && Array.IndexOf(nums, nums[index] + diff) > -1){ result++;}

            }

            return result;
    }
}
