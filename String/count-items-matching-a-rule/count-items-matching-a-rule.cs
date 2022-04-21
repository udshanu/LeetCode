public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int count = 0;
        foreach (var item in items)
        {
            switch (ruleKey)
            {
                case "type":
                    if (item[0].Equals(ruleValue))
                    {
                        count++;
                    }

                    break;
                case "color":
                    if (item[1].Equals(ruleValue))
                    {
                        count++;
                    }
                    break;
                case "name":
                    if (item[2].Equals(ruleValue))
                    {
                        count++;
                    }
                    break;
                default:
                    break;
            }
        }
        return count;
    }
}
