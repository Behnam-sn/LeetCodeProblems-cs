namespace LeetCodeProblems.Tests
{
    public class ContainsDuplicateTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, true)]
        [InlineData(new int[] { 1, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void Test_Pass(int[] nums, bool expected)
        {
            // Given
            // When
            var actual = ContainsDuplicate.Solution(nums);
            // Then
            Assert.Equal(expected, actual);
        }
    }
}
