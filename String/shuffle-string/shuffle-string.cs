public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] arr = new char[indices.Length];
        var sArr = s.ToCharArray();

        for (int i = 0; i < indices.Length; i++)
        {
            arr[indices[i]] = sArr[i];
        }

        return string.Concat(arr);
    }
}
