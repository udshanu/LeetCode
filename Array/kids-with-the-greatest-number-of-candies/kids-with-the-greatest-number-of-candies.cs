public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] result = new bool[candies.Length];
        int max = candies.Max();

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= max)
            {
                result[i] = true;
            }
            else
            {
                result[i] = false;
            }
        }

        return result;
    }
}
