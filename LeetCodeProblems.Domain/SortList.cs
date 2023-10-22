namespace LeetCodeProblems.Domain;
public class SortList
{
    public ListNode? Solution(ListNode? head)
    {
        if (head == null) return null;

        var list = Utils.ListNodeToList(head);
        list.Sort();
        return Utils.ListToListNode(list);
    }
}