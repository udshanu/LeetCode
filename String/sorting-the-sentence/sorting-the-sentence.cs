public class Solution {
    public string SortSentence(string s) {
        var wordArr = s.Split(' ');
        string[] arr = new string[wordArr.Length];

        for (int i = 0; i < wordArr.Length; i++)
        {
            string lastCharacter = wordArr[i].Substring(wordArr[i].Length - 1);
            string wordWithoutNumber = wordArr[i].Remove(wordArr[i].Length - 1, 1);

            arr[Convert.ToInt32(lastCharacter) - 1] = wordWithoutNumber;
        }

        return string.Join(" ", arr);
    }
}
