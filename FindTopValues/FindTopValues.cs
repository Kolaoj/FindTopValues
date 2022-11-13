namespace FindTopValues;

public class FindTopValues : IFindTopValues
{
    public int FindMaxValue(int[] anyOldValues)
    {
        return anyOldValues.MaxBy(x => x);
    }

    public int[] FindTopNValues(int[] anyOldValues, int n)
    {
        var orderedValues = anyOldValues.OrderByDescending(x => x).ToList();

        var valuesToReturn = new int[n];

        for (var i = 0; i < n; i++)
        {
            valuesToReturn[i] = orderedValues[i];
        }

        return valuesToReturn;
    }
}