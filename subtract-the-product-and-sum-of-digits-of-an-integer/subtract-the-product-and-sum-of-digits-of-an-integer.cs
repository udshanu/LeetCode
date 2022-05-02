public class Solution {
    public int SubtractProductAndSum(int n) {
        var strArr = n.ToString();

        int sum = 0;
        int product = 1;

        for (int i = 0; i < strArr.Length; i++)
        {
            int digit = Convert.ToInt32(strArr[i].ToString());
            product *= digit;
            sum += digit;
        }

        return product - sum;
    }
}
