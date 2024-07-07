namespace LeetCodeProblems;

// Group System Interview

public class BiggestSubsetOfSumOfN
{
    public static int[] Solution(int[] nums, int val)
    {
        Array.Sort(nums);
        var items = new List<int>();
        var sum = 0;

        foreach (var item in nums)
        {
            if (sum + item <= val)
            {
                sum += item;
                items.Add(item);
            }
            else
            {
                break;
            }
        }

        return items.ToArray();
    }
}