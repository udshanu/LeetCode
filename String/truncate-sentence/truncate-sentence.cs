public class Solution {
    public string TruncateSentence(string s, int k) {
        var arr = s.Split(' ');

        return String.Join(' ', arr, 0, k);
    }
}
