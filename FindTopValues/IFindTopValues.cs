namespace FindTopValues;

public interface IFindTopValues
{
    int FindMaxValue(int[] anyOldValues);
    int[] FindTopNValues(int[] anyOldValues, int n);
}