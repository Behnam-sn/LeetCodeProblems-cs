namespace LeetCodeProblems.Tests
{
    public class ValidAnagramTests
    {
        private readonly ValidAnagram sut;

        public ValidAnagramTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var s = "anagram";
            var t = "nagaram";
            // When
            var actual = sut.Solution(s, t);
            // Then
            Assert.True(actual);
        }

        [Fact]
        public void Test2()
        {
            // Given
            var s = "rat";
            var t = "car";
            // When
            var actual = sut.Solution(s, t);
            // Then
            Assert.False(actual);
        }
    }
}