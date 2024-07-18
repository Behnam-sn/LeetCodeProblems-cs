namespace LeetCodeProblems.Tests
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        public void Test_Pass(string s, int expected)
        {
            // Given
            // When
            var actual = LongestSubstringWithoutRepeatingCharacters.Solution(s);
            // Then
            Assert.Equal(expected, actual);
        }
    }
}
