public class Solution {
    public int MaxDepth(string s) {
        int bracketCount = 0;
        int depth = 0;
        foreach (var character in s)
        {
            if (character.Equals('('))
            {
                bracketCount++;
            }
            else if (character.Equals(')'))
            {
                bracketCount--;
            }

            if (bracketCount > depth)
            {
                depth = bracketCount;
            }
        }
        return depth;
    }
}
