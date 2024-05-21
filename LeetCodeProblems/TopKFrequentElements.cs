namespace LeetCodeProblems;

public class TopKFrequentElements
{
    public static int[] Solution(int[] nums, int k)
    {
        if (nums.Length == 0 || nums.Length == 1)
        {
            return nums;
        }

        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num] += 1;
            }
            else
            {
                dict[num] = 1;
            }
        }

        var pq = new PriorityQueue<int, int>();

        foreach (var item in dict)
        {
            pq.Enqueue(item.Key, item.Value);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        var result = new int[k];
        var i2 = k;

        while (pq.Count > 0)
        {
            result[--i2] = pq.Dequeue();
        }

        return result;
    }

    public int[] Solution1(int[] nums, int k)
    {
        if (nums.Length == 0 || nums.Length == 1)
        {
            return nums;
        }

        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num] += 1;
            }
            else
            {
                dict[num] = 1;
            }
        }

        var list = dict.ToList();

        list.Sort((x, y) => x.Value.CompareTo(y.Value));
        list.Reverse();

        var result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = list[i].Key;
        }

        return result;
    }

    public int[] Solution2(int[] nums, int k)
    {
        var result = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (result.ContainsKey(num))
            {
                result[num] += 1;
            }
            else
            {
                result[num] = 1;
            }
        }

        var w = new SortedDictionary<int, int>();

        foreach (var r in result)
        {
            w.Add(r.Value, r.Key);
        }

        var keys = w.Keys.ToList();
        keys.Reverse();

        var ak = new int[k];

        for (int i = 0; i < k; i++)
        {
            ak[i] = w[keys[i]];
        }

        return ak;
    }
}