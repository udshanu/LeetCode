public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        var containAll = target.Any(x => !arr.Contains(x));

        if (containAll)
        {
            return false;
        }

        for (int i = 0; i < target.Length; i++)
        {
            var index = Array.IndexOf(arr, target[i]);

            if (index == -1)
            {
                return false;
            }

            arr[index] = int.MaxValue;
        }

        return true;
    }
}
