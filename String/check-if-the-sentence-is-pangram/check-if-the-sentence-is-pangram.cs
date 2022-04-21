public class Solution {
    public bool CheckIfPangram(string sentence) {
    string alphabet = "abcdefghijklmnopqrstuvwxyz";

        if (sentence.Length >= 26)
        {
            foreach (var item in alphabet)
            {
                if (!sentence.Contains(item))
                {
                    return false;
                }
            }
        }
        else
        {
            return false;
        }

        return true;
    }
}
