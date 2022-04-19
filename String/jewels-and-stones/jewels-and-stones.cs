public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        char[] jewelsArr = jewels.ToCharArray();
        char[] stonesArr = stones.ToCharArray();
        int count = 0;

        foreach (var jewel in jewelsArr)
        {
            for (int j = 0; j < stonesArr.Length; j++)
            {
                if (jewel.Equals(stonesArr[j]))
                {
                    count++;
                }
            }
        }

        return count;
    }
}
