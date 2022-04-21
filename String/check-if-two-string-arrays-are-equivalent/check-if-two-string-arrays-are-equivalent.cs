public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string word1Str = String.Concat(word1);
        string word2Str = String.Concat(word2);

        if (word1Str.Equals(word2Str))
        {
            return true;
        }

        return false;
    }
}
