namespace LeetCodeProblems.Tests
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void Test(int[] nums, int target, int[] expected)
        {
            // Given
            // When
            var actual = TwoSum.Solution(nums, target);
            // Then
            Assert.Equal(expected, actual);
        }
    }
}