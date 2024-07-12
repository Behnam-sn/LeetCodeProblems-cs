namespace LeetCodeProblems;

public class RotateArray
{
    public static void Solution1(int[] nums, int k)
    {
        for (var i = 0; i < k; i++)
        {
            var current = nums[nums.Length - 1];
            for (var j = nums.Length - 1; j > 0; j--)
            {
                nums[j] = nums[j - 1];
            }
            nums[0] = current;
        }
    }

    public static void Solution2(int[] nums, int k)
    {
        if (nums.Length < 2)
        {
            return;
        }

        if (nums.Length < k)
        {
            var x = k % nums.Length;
            for (var i = 0; i < x; i++)
            {
                var current = nums[nums.Length - 1];
                for (var j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = current;
            }
        }
        else
        {
            var lastHalf = nums.TakeLast(k).ToArray();

            for (int i = nums.Length - 1; i >= k; i--)
            {
                nums[i] = nums[i - k];
            }

            for (int i = 0; i < lastHalf.Length; i++)
            {
                nums[i] = lastHalf[i];
            }
        }
    }

    public static void Solution3(int[] nums, int k)
    {
        if (nums == null || nums.Length < 2)
        {
            return;
        }

        if (nums.Length <= k)
        {
            k %= nums.Length;
        }

        if (k == 0)
        {
            return;
        }

        var lastHalf = nums.TakeLast(k).ToArray();

        for (int i = nums.Length - 1; i >= k; i--)
        {
            nums[i] = nums[i - k];
        }

        for (int i = 0; i < lastHalf.Length; i++)
        {
            nums[i] = lastHalf[i];
        }
    }

    // Not Working
    public static void Solution4(int[] nums, int k)
    {
        if (nums == null || nums.Length < 2)
        {
            return;
        }

        if (nums.Length <= k)
        {
            k %= nums.Length;
        }

        if (k == 0)
        {
            return;
        }

        var hold = nums[0];
        var j = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var x = j + k;
            if (x >= nums.Length)
            {
                x -= nums.Length;
            }
            (hold, nums[x]) = (nums[x], hold);
            j = x;
        }
    }

    // Not Original
    public static void Solution5(int[] nums, int k)
    {
        if (nums == null || nums.Length < 2)
        {
            return;
        }

        if (nums.Length <= k)
        {
            k %= nums.Length;
        }

        if (k == 0)
        {
            return;
        }

        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, nums.Length - k);
    }

    // Not Original
    public static void Solution6(int[] nums, int k)
    {
        if (nums == null || nums.Length < 2)
        {
            return;
        }

        if (nums.Length <= k)
        {
            k %= nums.Length;
        }

        if (k == 0)
        {
            return;
        }

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    private static void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            (nums[end], nums[start]) = (nums[start], nums[end]);
            start++;
            end--;
        }
    }
}
