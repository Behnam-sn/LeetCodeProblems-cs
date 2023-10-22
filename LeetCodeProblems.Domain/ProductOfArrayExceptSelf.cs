namespace LeetCodeProblems.Domain;

public class ProductOfArrayExceptSelf
{
    public int[] Solution(int[] nums)
    {
        var result = new int[nums.Length];

        var prefix = 1;
        var postfix = 1;

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }

    public int[] Solution1(int[] nums)
    {
        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var temp = 1;
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                temp *= nums[j];
            }

            result[i] = temp;
        }

        return result;
    }
}