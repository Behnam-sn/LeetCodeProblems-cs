namespace LeetCodeProblems;

// Group System Interview

public class Interval
{
    public DateTime StartTime;
    public DateTime EndTime;

    public Interval(DateTime startTime, DateTime endTime)
    {
        StartTime = startTime;
        EndTime = endTime;
    }
}

public class ValidInterval
{
    public static bool Solution1(Interval[] intervals)
    {
        for (int i = 0; i < intervals.Length; i++)
        {
            var item1 = intervals[i];
            for (var j = i + 1; j < intervals.Length; j++)
            {
                var item2 = intervals[j];

                var isStartTimeConflicted = item2.StartTime >= item1.StartTime && item2.StartTime <= item1.EndTime;
                var isEndTimeConflicted = item2.EndTime >= item1.StartTime && item2.EndTime <= item1.EndTime;
                if (isStartTimeConflicted || isEndTimeConflicted)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool Solution2(Interval[] intervals)
    {
        var sortedIntervals = intervals.OrderBy(interval => interval.StartTime).ToArray();
        for (var i = 0; i < intervals.Length - 1; i++)
        {
            if (sortedIntervals[i].EndTime >= sortedIntervals[i + 1].StartTime)
            {
                return false;
            }
        }
        return true;
    }
}
