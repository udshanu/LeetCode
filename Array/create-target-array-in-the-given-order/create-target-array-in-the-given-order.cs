public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        int?[] tempArray = new int?[index.Length];
            
        for (int i = 0; i < index.Length; i++)
        {
            if (tempArray[index[i]] != null)
            {
                var restArray = tempArray.Skip(index[i]).Take(i).ToArray();

                int newIndex = index[i];

                tempArray[index[i]] = nums[i];

                foreach (var item in restArray)
                {
                    newIndex++;
                    if (newIndex < index.Length)
                    {
                        tempArray[newIndex] = item;
                    }
                }
            }
            else
            {
                tempArray[index[i]] = nums[i];
            }
        }

        int[] result = Array.ConvertAll(tempArray, x => x ?? 0);

        return result;
    }
}
