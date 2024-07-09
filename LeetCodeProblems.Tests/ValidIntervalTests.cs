namespace LeetCodeProblems.Tests;

public class ValidIntervalTests
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] {
                new Interval[] {
                    new Interval(DateTime.Now.AddMonths(2), DateTime.Now.AddMonths(3)),
                    new Interval(DateTime.Now, DateTime.Now.AddMonths(1)),
                    new Interval(DateTime.Now.AddMonths(4), DateTime.Now.AddMonths(5)),
                 },
                true
                };
        yield return new object[] {
                new Interval[] {
                    new Interval(DateTime.Now.AddMonths(1), DateTime.Now.AddMonths(2)),
                    new Interval(DateTime.Now.AddMonths(3), DateTime.Now.AddMonths(4)),
                    new Interval(DateTime.Now, DateTime.Now.AddMonths(1)),
                 },
                false
                };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(Interval[] intervals, bool expected)
    {
        // Given
        // When
        var actual = ValidInterval.Solution2(intervals);
        // Then
        Assert.Equal(expected, actual);
    }
}