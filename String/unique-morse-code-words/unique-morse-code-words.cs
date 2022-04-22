public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] tempArr = new string[words.Length];
        string[] encodingArr = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        List<string> alphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string tempString = string.Empty;
            for (int j = 0; j < word.Length; j++)
            {
                int index = alphabet.FindIndex(x => x.Contains(word[j]));

                tempString = tempString + encodingArr[index];
            }

            tempArr[i] = tempString;
        }

        return tempArr.ToList().Distinct().Count();
    }
}
