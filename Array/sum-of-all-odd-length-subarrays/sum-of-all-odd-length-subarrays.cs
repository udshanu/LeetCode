public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        var odd = Enumerable.Range(1, arr.Length).Where(i => i % 2 != 0).ToArray();

        int result = 0;
        for (int i = 0; i < odd.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                var bb = arr.Skip(j).Take(odd[i]).ToArray();

                if (odd[i] == bb.Length)
                {
                    var sum = bb.Sum();

                    result += sum;
                }
            }
        }

        return result;
    }
}
