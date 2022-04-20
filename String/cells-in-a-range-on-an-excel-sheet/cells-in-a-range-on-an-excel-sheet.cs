public class Solution {
    public IList<string> CellsInRange(string s) {
        List<string> outArr = new List<string>();
        var sArr = s.ToCharArray();

        for (char letter = sArr[0]; letter <= sArr[3]; letter++)
        {
            for (char i = sArr[1]; i <= sArr[4]; i++)
            {
                outArr.Add($"{letter}{i}");
            }
        }

        return outArr;
    }
}
