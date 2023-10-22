namespace LeetCodeProblems.Tests
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        private readonly LongestSubstringWithoutRepeatingCharacters sut;

        public LongestSubstringWithoutRepeatingCharactersTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            // When
            var result = sut.Solution("abcabcbb");
            // Then
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test2()
        {
            // Given
            // When
            var result = sut.Solution("bbbbb");
            // Then
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test3()
        {
            // Given
            // When
            var result = sut.Solution("pwwkew");
            // Then
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test4()
        {
            // Given
            // When
            var result = sut.Solution("");
            // Then
            Assert.Equal(0, result);
        }
    }
}