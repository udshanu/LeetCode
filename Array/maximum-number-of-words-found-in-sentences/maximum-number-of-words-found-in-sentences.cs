public class Solution {
    public int MostWordsFound(string[] sentences) {
        int output = 0;
        foreach (var sentence in sentences)
        {
            var words = sentence.Split(' ');
            if (words.Length > output)
            {
                output = words.Length;
            }
        }

        return output;
    }
}
