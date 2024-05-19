using LeetCodeProblems.Shared;

namespace LeetCodeProblems;
public class MergeTwoSortedLists
{
    public ListNode? Solution(ListNode? list1, ListNode? list2)
    {
        if (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                return new ListNode(list1.val, Solution(list1.next, list2));
            }

            return new ListNode(list2.val, Solution(list1, list2.next));
        }

        if (list1 != null && list2 == null)
        {
            return new ListNode(list1.val, Solution(list1.next, null));
        }

        if (list1 == null && list2 != null)
        {
            return new ListNode(list2.val, Solution(null, list2.next));
        }

        return null;
    }
}