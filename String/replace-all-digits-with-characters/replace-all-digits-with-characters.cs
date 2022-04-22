public class Solution {
    public string ReplaceDigits(string s) {
        var arr = s.ToCharArray();
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 1)
            {
                var prvCharAscii = (int)(s[i - 1]);
                var numValue = Convert.ToInt32(s[i].ToString());

                arr[i] = Convert.ToChar(prvCharAscii + numValue);
            }
        }

        return String.Concat(arr);
    }
}
