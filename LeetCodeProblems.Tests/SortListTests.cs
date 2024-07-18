using LeetCodeProblems.Shared;

namespace LeetCodeProblems.Tests
{
    public class SortListTests
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] { Utils.ListToListNode(new List<int> { 4, 2, 1, 3 }), new List<int> { 1, 2, 3, 4 } };
            yield return new object[] { Utils.ListToListNode(new List<int> { -1, 5, 3, 4, 0 }), new List<int> { -1, 0, 3, 4, 5 } };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(ListNode? head, IEnumerable<int>? expected)
        {
            // Given
            // When
            var result = SortList.Solution(head);
            // Then
            var actual = Utils.ListNodeToList(result);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test1()
        {
            // Given
            // When
            var result = SortList.Solution(null);
            // Then
            Assert.Null(result);
        }
    }
}
