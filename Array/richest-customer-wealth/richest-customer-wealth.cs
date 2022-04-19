public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            int tempMaxWealth = 0;
            for (int j = 0; j < (accounts[i]).Length; j++)
            {
                tempMaxWealth = tempMaxWealth + accounts[i][j];
            }

            if (tempMaxWealth > maxWealth)
            {
                maxWealth = tempMaxWealth;
            }
        }

        return maxWealth;
    }
}
