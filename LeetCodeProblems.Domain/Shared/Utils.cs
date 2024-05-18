namespace LeetCodeProblems.Domain.Shared;

public class Utils
{
    public static string ListToString(List<int> list)
    {
        return string.Join("", list);
    }

    public static int StringToList(string text)
    {
        return text == "" ? 0 : int.Parse(text);
    }

    public static string ListNodeToString(ListNode? list)
    {
        if (list != null && list.val != null)
        {
            return list.val + ListNodeToString(list.next);
        }

        return "";
    }

    public static ListNode StringToListNode(string str)
    {
        var head = new ListNode();
        var tail = head;

        for (int i = 0; i < str.Length; i++)
        {
            tail.val = int.Parse(str[i].ToString());

            if (i < str.Length - 1)
            {
                tail.next = new ListNode();
                tail = tail.next;
            }
        }

        return head;
    }

    public static List<int> ListNodeToList(ListNode? head)
    {
        var list = new List<int>();
        var tail = head;

        while (tail != null)
        {
            if (tail.val != null)
            {
                list.Add((int)tail.val);
            }

            tail = tail.next;
        }

        return list;
    }

    public static ListNode ListToListNode(List<int> list)
    {
        var head = new ListNode();
        var tail = head;

        for (int i = 0; i < list.Count; i++)
        {
            tail.val = list[i];

            if (i < list.Count - 1)
            {
                tail.next = new ListNode();
                tail = tail.next;
            }
        }

        return head;
    }

    public static string SortString(string input)
    {
        var characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }

    // public static Stack<T> ListToStack<T>(List<T> list)
    // {
    //     return new Stack<T>(list);
    // }

    // public static ListNode? StackToListNode(Stack<int> stack)
    // {
    //     if (stack.Count > 0)
    //     {
    //         return new ListNode(stack.Pop(), StackToListNode(stack));
    //     }

    //     return null;
    // }
}