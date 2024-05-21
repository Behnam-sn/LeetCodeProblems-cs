using LeetCodeProblems.Shared;

namespace LeetCodeProblems;
public class SortList
{
    public static ListNode? Solution(ListNode? head)
    {
        if (head == null) return null;

        var list = Utils.ListNodeToList(head);
        list.Sort();
        return Utils.ListToListNode(list);
    }
}