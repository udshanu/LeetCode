public class Solution {
    public int MinimumSum(int num) {
        int[] digitArr = num.ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray();
        Array.Sort(digitArr);

        return Convert.ToInt32($"{digitArr[0]}{digitArr[3]}") + Convert.ToInt32($"{digitArr[1]}{digitArr[2]}");
    }
}
