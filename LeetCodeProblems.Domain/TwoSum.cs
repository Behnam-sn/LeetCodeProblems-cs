namespace LeetCodeProblems.Domain;

public class TwoSum
{
    public int[]? Solution1(int[] nums, int target)
    {
        for (int x = 0; x < nums.Length; x++)
        {
            for (int y = x + 1; y < nums.Length; y++)
            {
                if (nums[x] + nums[y] == target) return new int[] { x, y };
            }
        }

        return null;
    }

    public int[]? Solution(int[] nums, int target)
    {
        var indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (indices.ContainsKey(diff)) return new int[] { indices[diff], i };

            indices[nums[i]] = i;
        }

        return null;
    }
}