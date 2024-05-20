using LeetCodeProblems.Shared;

namespace LeetCodeProblems;

public class GroupAnagrams
{
    public static IList<IList<string>> Solution(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            var key = Utils.SortString(str);
            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            groups[key].Add(str);
        }

        return groups.Values.ToList();
    }
}