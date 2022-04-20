public class Solution {
    public int BalancedStringSplit(string s) {
        int count = 0;
        int lCounter = 0;
        int rCounter = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals('R'))
            {
                rCounter++;
            }
            else
            {
                lCounter++;
            }

            if (rCounter == lCounter)
            {
                count++;
            }
        }

        return count;
    }
}
