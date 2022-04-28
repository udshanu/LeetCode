public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        for (int i = 0; i < image.GetLength(0); i++)
        {
            Array.Reverse(image[i]);

            for (int j = 0; j < image[i].GetLength(0); j++)
            {
                image[i][j] = image[i][j] ^ 1;
            }
        }

        return image;
    }
}
