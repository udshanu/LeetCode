public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        var rowLen = mat.GetLength(0);
        var colLen = mat[0].GetLength(0);

        int[] tempArr = new int[rowLen];
        int[] copyArr = new int[rowLen];
        int[] resultArr = new int[k];

        for (int i = 0; i < rowLen; i++)
        {
            int count = 0;
            for (int j = 0; j < colLen; j++)
            {
                if (mat[i][j] == 1)
                {
                    count++;
                }
            }

            tempArr[i] = count;
        }

        Array.Copy(tempArr, copyArr, rowLen);

        Array.Sort(tempArr);

        for (int i = 0; i < k; i++)
        {
            int index = Array.IndexOf(copyArr, tempArr[i]);
            resultArr[i] = index;
            copyArr[index] = int.MaxValue;
        }

        return resultArr;
    }
}
