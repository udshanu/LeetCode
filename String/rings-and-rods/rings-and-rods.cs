public class Solution {
    public int CountPoints(string rings) {
        int[] r = new int[10];
        int[] g = new int[10];
        int[] b = new int[10];

        for (int i = 0; i < rings.Length; i++)
        {
            if (i < rings.Length - 1)
            {
                var rodIndex = rings[i + 1].ToString();

                if (rings[i].Equals('R'))
                {
                    r[Convert.ToInt32(rodIndex)]++;
                }
                else if (rings[i].Equals('G'))
                {
                    g[Convert.ToInt32(rodIndex)]++;
                }
                else if (rings[i].Equals('B'))
                {
                    b[Convert.ToInt32(rodIndex)]++;
                }
                else
                {
                    continue;
                }
            }
        }

        int output = 0;
        for (int j = 0; j < 10; j++)
        {
            if (r[j] > 0 && g[j] > 0 && b[j] > 0)
            {
                output++;
            }
        }

        return output;
    }
}
