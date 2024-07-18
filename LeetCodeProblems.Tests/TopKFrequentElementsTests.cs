namespace LeetCodeProblems.Tests
{
    public class TopKFrequentElementsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 1, 2, 2, 3 }, 2, new int[] { 1, 2 })]
        [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
        public void Test(int[] nums, int k, int[] expected)
        {
            // Given
            // When
            var actual = TopKFrequentElements.Solution(nums, k);
            // Then
            Assert.Equal(expected, actual);
        }
    }
}
