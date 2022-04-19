public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int output = 0;
        foreach (var operation in operations)
        {
            if (operation.Equals("X++") || operation.Equals("++X"))
            {
                output++;
            }
            else if (operation.Equals("X--") || operation.Equals("--X"))
            {
                output--;
            }
            else
            {
                continue;
            }
        }

        return output;
    }
}
