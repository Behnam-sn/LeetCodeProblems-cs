using LeetCodeProblems.Shared;

namespace LeetCodeProblems.Tests
{
    public class UtilsTests
    {
        [Fact]
        public void ListToListNodeTest()
        {
            // Given
            var list = new List<int>() { 2, 4, 3 };
            var listNode = new ListNode(
                val: 2,
                next: new ListNode(
                    val: 4,
                    next: new ListNode(
                        val: 3,
                        next: null
                    )
                )
            );
            // When
            var result = Utils.ListToListNode(list);
            // Then
            result.Should().BeEquivalentTo(listNode);
        }
        [Fact]
        public void ListNodeToStringTest()
        {
            // Given
            var listNode = new ListNode(
                val: 2,
                next: new ListNode(
                    val: 4,
                    next: new ListNode(
                        val: 3,
                        next: null
                    )
                )
            );
            // When
            var result = Utils.ListNodeToString(listNode);
            // Then
            result.Should().BeEquivalentTo("243");
        }
        [Fact]
        public void StringToListNodeTest()
        {
            // Given
            var listNode = new ListNode(
                val: 2,
                next: new ListNode(
                    val: 4,
                    next: new ListNode(
                        val: 3,
                        next: null
                    )
                )
            );
            // When
            var result = Utils.StringToListNode("243");
            // Then
            result.Should().BeEquivalentTo(listNode);
        }
    }
}