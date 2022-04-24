public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        List<int> result = new List<int>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
