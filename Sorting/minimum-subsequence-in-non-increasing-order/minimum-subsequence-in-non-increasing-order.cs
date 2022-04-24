public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        List<int> result = new List<int>();
        Array.Sort(nums);
        Array.Reverse(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            int sum = nums.Take(i + 1).Sum();
            int restSum = nums.Skip(i + 1).Take(nums.Length - (i + 1)).Sum();

            if (sum > restSum)
            {
                result.Add(nums[i]);
                return result;
            }

            result.Add(nums[i]);

        }

        return result;
    }
}
