namespace LeetCodeProblems.Tests
{
    public class ContainsDuplicateTests
    {
        private readonly ContainsDuplicate sut;

        public ContainsDuplicateTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var nums = new int[] { 1, 2, 3, 1 };
            // When
            var actual = sut.Solution(nums);
            // Then
            Assert.True(actual);
        }

        [Fact]
        public void Test2()
        {
            // Given
            var nums = new int[] { 1, 2, 3, 4 };
            // When
            var actual = sut.Solution(nums);
            // Then
            Assert.False(actual);
        }

        [Fact]
        public void Test3()
        {
            // Given
            var nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            // When
            var actual = sut.Solution(nums);
            // Then
            Assert.True(actual);
        }
    }
}