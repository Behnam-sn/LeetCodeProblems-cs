using LeetCodeProblems.Shared;

namespace LeetCodeProblems;

public class AddTwoNumbers
{
    public ListNode? Solution(ListNode? l1, ListNode? l2)
    {
        var head = new ListNode();
        var tail = head;
        var sum = 0;
        var leftOver = 0;

        while (true)
        {
            sum = (l1 == null ? 0 : l1.val ?? 0) + (l2 == null ? 0 : l2.val ?? 0) + leftOver;
            leftOver = sum / 10;
            tail.val = sum % 10;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;

            if (l1 == null && l2 == null)
            {
                if (leftOver > 0)
                {
                    tail.next = new ListNode(val: leftOver);
                }

                break;
            }

            tail.next = new ListNode();
            tail = tail.next;
        }

        return head;
    }
}