public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        
        List<int> output = new List<int>();

        for (int i = 0; i < queries.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < points.Length; j++)
            {
                var euclideanDistance = Math.Sqrt(Math.Pow((Convert.ToDouble(queries[i][0]) - Convert.ToDouble(points[j][0])), 2) + Math.Pow((Convert.ToDouble(queries[i][1]) - Convert.ToDouble(points[j][1])), 2));

                if (queries[i][2] >= euclideanDistance)
                {
                    count++;
                }
            }

            output.Add(count);
        }

        return output.ToArray();
    }
}
