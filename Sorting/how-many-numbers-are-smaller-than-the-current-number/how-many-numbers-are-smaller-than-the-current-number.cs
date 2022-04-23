public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
       int[] resutlArr = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                if (nums[i] > nums[j])
                {
                    count++;
                }
            }

            resutlArr[i] = count;
        }

        return resutlArr; 
    }
}
