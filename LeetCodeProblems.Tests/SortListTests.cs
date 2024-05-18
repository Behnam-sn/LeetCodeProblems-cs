using LeetCodeProblems.Domain.Shared;

namespace LeetCodeProblems.Tests
{
    public class SortListTests
    {
        private readonly SortList sut;

        public SortListTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var head = Utils.ListToListNode(new List<int> { 4, 2, 1, 3 });
            // When
            var result = sut.Solution(head);
            // Then
            var expected = new List<int> { 1, 2, 3, 4 };
            Assert.Equal(expected, Utils.ListNodeToList(result));
        }

        [Fact]
        public void Test2()
        {
            // Given
            var head = Utils.ListToListNode(new List<int> { -1, 5, 3, 4, 0 });
            // When
            var result = sut.Solution(head);
            // Then
            var expected = new List<int> { -1, 0, 3, 4, 5 };
            Assert.Equal(expected, Utils.ListNodeToList(result));
        }

        [Fact]
        public void Test3()
        {
            // Given
            // When
            var result = sut.Solution(null);
            // Then
            Assert.Null(result);
        }
    }
}