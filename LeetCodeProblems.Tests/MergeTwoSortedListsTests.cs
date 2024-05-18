using LeetCodeProblems.Domain.Shared;

namespace LeetCodeProblems.Tests
{
    public class MergeTwoSortedListsTests
    {
        private readonly MergeTwoSortedLists sut;

        public MergeTwoSortedListsTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var l1 = Utils.StringToListNode("124");
            var l2 = Utils.StringToListNode("134");
            // When
            var result = sut.Solution(l1, l2);
            // Then
            Assert.Equal("112344", Utils.ListNodeToString(result));
        }

        [Fact]
        public void Test2()
        {
            // Given
            var l1 = Utils.StringToListNode("");
            var l2 = Utils.StringToListNode("");
            // When
            var result = sut.Solution(l1, l2);
            // Then
            Assert.Equal("", Utils.ListNodeToString(result));
        }

        [Fact]
        public void Test3()
        {
            // Given
            var l1 = Utils.StringToListNode("");
            var l2 = Utils.StringToListNode("0");
            // When
            var result = sut.Solution(l1, l2);
            // Then
            Assert.Equal("0", Utils.ListNodeToString(result));
        }
    }
}