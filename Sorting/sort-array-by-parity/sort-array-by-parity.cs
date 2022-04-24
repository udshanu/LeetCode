public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int[] result = new int[nums.Length];
            
        var evenList = nums.Where(x => x % 2 == 0).ToArray();
        var oddList = nums.Where(x => x % 2 == 1).ToArray();

        Array.Copy(evenList, result, evenList.Length);
        Array.Copy(oddList, 0, result, evenList.Length, oddList.Length);

        return result;
    }
}
