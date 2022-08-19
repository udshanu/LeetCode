public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum = 0;

        if (mat.GetLength(0) % 2 == 1)
        {
            sum = sum + GetPrimaryDiagonalSum(mat);
            sum = sum + GetSecondaryDiagonalSum(mat);
        }
        else
        {
            sum = sum + GetPrimaryDiagonalSum(mat);
            sum = sum + GetSecondaryDiagonalSum(mat);
        }

        return sum;
    }
    
    private int GetPrimaryDiagonalSum(int[][] mat)
    {
        int sum = 0;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            sum = sum + mat[i][i];
        }

        return sum;
    }
    
    private int GetSecondaryDiagonalSum(int[][] mat)
    {
        int sum = 0;
        int x = mat.GetLength(0) / 2;
        int y = mat.GetLength(0) - 1;

        for (int j = 0; j < x; j++)
        {
            sum = sum + mat[j][y];
            sum = sum + mat[y][j];
            y--;
        }

        return sum;
    }
}
