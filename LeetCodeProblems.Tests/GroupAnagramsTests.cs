namespace LeetCodeProblems.Tests
{
    public class GroupAnagramsTests
    {
        public static IEnumerable<object[]> GetData()
        {
            yield return new object[] {
                new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new List<IList<string>> { new List<string> { "eat", "tea", "ate" }, new List<string> { "tan", "nat" }, new List<string> { "bat" } }
                };
            yield return new object[] {
                new string[] { "" },
                new List<IList<string>> { new List<string> { "" } }
                };
            yield return new object[] {
                new string[] { "a" },
                new List<IList<string>> { new List<string> { "a" } }
                };
        }

        [Theory]
        [MemberData(nameof(GetData))]
        public void Test(string[] strs, List<IList<string>> expected)
        {
            // Given
            // When
            var actual = GroupAnagrams.Solution(strs);
            // Then
            Assert.Equal(expected, actual);
        }
    }
}