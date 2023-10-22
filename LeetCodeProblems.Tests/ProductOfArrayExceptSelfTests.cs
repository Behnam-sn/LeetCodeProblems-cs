namespace LeetCodeProblems.Tests
{
    public class ProductOfArrayExceptSelfTests
    {
        private readonly ProductOfArrayExceptSelf sut;

        public ProductOfArrayExceptSelfTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var nums = new int[] { 1, 2, 3, 4 };
            // When
            var actual = sut.Solution(nums);
            var expected = new int[] { 24, 12, 8, 6 };
            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            // Given
            var nums = new int[] { -1, 1, 0, -3, 3 };
            // When
            var actual = sut.Solution(nums);
            var expected = new int[] { 0, 0, 9, 0, 0 };
            // Then
            Assert.Equal(expected, actual);
        }
    }
}