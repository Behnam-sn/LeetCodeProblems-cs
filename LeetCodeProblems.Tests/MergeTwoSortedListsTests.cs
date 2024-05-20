using LeetCodeProblems.Shared;

namespace LeetCodeProblems.Tests;

public class MergeTwoSortedListsTests
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] { Utils.StringToListNode("124"), Utils.StringToListNode("134"), "112344" };
        yield return new object[] { Utils.StringToListNode(""), Utils.StringToListNode(""), "" };
        yield return new object[] { Utils.StringToListNode(""), Utils.StringToListNode("0"), "0" };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(ListNode l1, ListNode l2, string expected)
    {
        // Given
        // When
        var actual = MergeTwoSortedLists.Solution(l1, l2);
        // Then
        Assert.Equal(expected, Utils.ListNodeToString(actual));
    }
}