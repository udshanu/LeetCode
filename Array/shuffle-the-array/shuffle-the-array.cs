public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var output = new int[nums.Length];
        int y = 0;
        for (int i = 0; i < n; i++)
        {
            output[y] = nums[i];
            y++;
            output[y] = nums[(i + n)];
            y++;

        }

        return output;
    }
}
