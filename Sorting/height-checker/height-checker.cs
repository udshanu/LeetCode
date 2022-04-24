public class Solution {
    public int HeightChecker(int[] heights) {
        int[] initArr = new int[heights.Length];
        Array.Copy(heights, initArr, heights.Length);

        Array.Sort(heights);

        int count = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            if (initArr[i] != heights[i])
            {
                count++;
            }
        }

        return count;
    }
}
