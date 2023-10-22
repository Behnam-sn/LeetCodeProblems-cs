namespace LeetCodeProblems.Tests
{
    public class GroupAnagramsTests
    {
        private readonly GroupAnagrams sut;

        public GroupAnagramsTests()
        {
            sut = new();
        }

        [Fact]
        public void Test1()
        {
            // Given
            var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            // When
            var actual = sut.Solution(strs);
            // Then
            var expected = new List<IList<string>> { new List<string> { "eat", "tea", "ate" }, new List<string> { "tan", "nat" }, new List<string> { "bat" } };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            // Given
            var strs = new string[] { "" };
            // When
            var actual = sut.Solution(strs);
            // Then
            var expected = new List<List<string>> { new List<string> { "" } };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            // Given
            var strs = new string[] { "a" };
            // When
            var actual = sut.Solution(strs);
            // Then
            var expected = new List<List<string>> { new List<string> { "a" } };
            Assert.Equal(expected, actual);
        }
    }
}