public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        var newRowLength = grid.GetLength(0) - 2;
            var newColumnLength = grid[0].GetLength(0) - 2;

            int[][] resultJuggedArray = new int[newRowLength][];

            for (int i = 0; i < newRowLength; i++)
            {
                int[] tempArray = new int[newColumnLength];
                for (int j = 0; j < newColumnLength; j++)
                {
                    tempArray[j] = GetMaxValue(CreateJuggedArray(grid, i, j));
                }

                resultJuggedArray[i] = tempArray;
            }

            return resultJuggedArray;
    }
    
    public int GetMaxValue(int[][] grid)
    {
        int max = 0;
        for (int i = 0; i < 3; i++)
        {
            int maxValue = grid[i].Max();
            if (maxValue > max)
            {
                max = maxValue;
            }
        }
        return max;
    }
    
    public int[][] CreateJuggedArray(int[][] grid, int i, int j)
    {
        int[][] tempJuggedArray = new int[3][];

        int c = i;
        for (int l = 0; l < 3; l++)
        {
            tempJuggedArray[l] = new int[3] { grid[c][j], grid[c][j + 1], grid[c][j + 2] };
            c++;
        }

        return tempJuggedArray;
    }
}
