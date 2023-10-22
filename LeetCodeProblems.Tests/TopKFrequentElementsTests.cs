namespace LeetCodeProblems.Tests
{
    public class TopKFrequentElementsTests
    {
        private readonly TopKFrequentElements sut;

        public TopKFrequentElementsTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;
            // When
            var actual = sut.Solution(nums, k);
            // Then
            var expected = new int[] { 1, 2 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            // Given
            var nums = new int[] { 1 };
            var k = 1;
            // When
            var actual = sut.Solution(nums, k);
            // Then
            var expected = new int[] { 1 };
            Assert.Equal(expected, actual);
        }
    }
}