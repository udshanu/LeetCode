public class SubrectangleQueries {

    public int[][] Rectangle { get; set; }
    
    public SubrectangleQueries(int[][] rectangle) {
        this.Rectangle = rectangle;
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
        for (int i = row1; i <= row2; i++) //row
        {
            for (int j = col1; j <= col2; j++)
            {
                this.Rectangle[i][j] = newValue;
            }
        }
    }
    
    public int GetValue(int row, int col) {
        return this.Rectangle[row][col];
    }
}

/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */
