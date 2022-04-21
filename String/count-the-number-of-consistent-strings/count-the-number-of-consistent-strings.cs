public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int notAllowedCount = 0;
        foreach (var word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!allowed.Contains(word[i]))
                {
                    notAllowedCount++;
                    break;
                }
            }
        }

        return words.Length - notAllowedCount;
    }
}
