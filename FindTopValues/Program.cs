namespace FindTopValues;

class Program
{
    public static void Main(string[] args)
    {
        var instance = new FindTopValues();
        var findTopValuesService = new FindTopValuesService(instance);

        Console.WriteLine(findTopValuesService.FindMaxValue(new[] { 4, 5, 2, 6, 1, 9 }));

        foreach (var value in findTopValuesService.FindTopNValues(new[] { 4, 5, 2, 6, 1, 9 }, 2))
        {
            Console.WriteLine(value);     
        }
    }
}

public class FindTopValuesService
{
    private readonly IFindTopValues _findTopValues;

    public FindTopValuesService(IFindTopValues findTopValues)
    {
        _findTopValues = findTopValues;
    }

    public int FindMaxValue(int[] anyOldValues)
    {
        return _findTopValues.FindMaxValue(anyOldValues);
    }

    public int[] FindTopNValues(int[] anyOldValues, int n)
    {
        return _findTopValues.FindTopNValues(anyOldValues, n);
    }
}