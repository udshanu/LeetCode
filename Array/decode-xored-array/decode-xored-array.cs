public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] res = new int[encoded.Length + 1];
        res[0] = first;

        for (int i = 0; i < encoded.Length; i++)
        {
            res[i + 1] = res[i] ^ encoded[i];
        }

        return res;
    }
}
