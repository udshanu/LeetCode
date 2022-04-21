public class Solution {
    public string RemoveOuterParentheses(string s) {
        List<string> tempStack = new List<string>();

        string temp = string.Empty;
        int openBracketCount = 0;
        int closeBracketCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].Equals('('))
            {
                openBracketCount++;
                temp += s[i];
            }
            else
            {
                closeBracketCount++;
                temp += s[i];
            }

            if (openBracketCount == closeBracketCount)
            {
                tempStack.Add(temp);
                temp = string.Empty;
                openBracketCount = 0;
                closeBracketCount = 0;
            }

        }

        string output = string.Empty;
        foreach (var item in tempStack)
        {
            string result = item.Substring(1, item.Length - 2);
            output += result;
        }

        return output;
    }
}
