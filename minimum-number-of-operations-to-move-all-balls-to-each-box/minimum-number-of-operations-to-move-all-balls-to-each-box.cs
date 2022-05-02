public class Solution {
    public int[] MinOperations(string boxes) {
        List<int> output = new List<int>();

        for (int i = 0; i < boxes.Length; i++)
        {
            int moves = 0;
            for (int j = 0; j < boxes.Length; j++)
            {
                if (boxes[j].Equals('1'))
                {
                    moves += Math.Abs(i - j);
                }
            }

            output.Add(moves);
        }

        return output.ToArray();
    }
}
