namespace LeetCodeProblems;

public class ContainsDuplicate
{
    public static bool Solution(int[] nums)
    {
        var hashset = new HashSet<int>();

        foreach (int num in nums)
        {
            if (hashset.Contains(num) == true) return true;
            hashset.Add(num);
        }

        return false;
    }
}
