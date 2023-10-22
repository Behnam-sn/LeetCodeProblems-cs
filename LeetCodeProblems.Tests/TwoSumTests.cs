namespace LeetCodeProblems.Tests
{
    public class TwoSumTests
    {
        private readonly TwoSum sut;

        public TwoSumTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            // When
            var actual = sut.Solution(nums, target);
            // Then
            var expected = new int[] { 0, 1 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            // Given
            var nums = new int[] { 3, 2, 4 };
            var target = 6;
            // When
            var actual = sut.Solution(nums, target);
            // Then
            var expected = new int[] { 1, 2 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            // Given
            var nums = new int[] { 3, 3 };
            var target = 6;
            // When
            var actual = sut.Solution(nums, target);
            // Then
            var expected = new int[] { 0, 1 };
            Assert.Equal(expected, actual);
        }
    }
}