public class Solution {
    public int MinPartitions(string n) {
        int min = int.MinValue;

        for (int i = 0; i < n.Length; i++)
        {
            var value = Convert.ToInt32(n[i].ToString());

            min = min < value ? value : min;

        }

        return min;
    }
}
