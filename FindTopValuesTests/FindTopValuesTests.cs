namespace FindTopValuesTests;

public class FindTopValuesTests
{
    private FindTopValues.FindTopValues _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new FindTopValues.FindTopValues();
    }

    //Find Max Values Test
    [Test]
    public void FindMaxValue_Returns_Correct_Value_When_Given_Array_Of_Positive_Integers_In_Descending_Order()
    {
        //Arrange

        var descendingNumbers = new[] { 8, 7, 6, 5, 4, 3, 2, 1 };

        //Act

        var result = _sut.FindMaxValue(descendingNumbers);

        //Assert

        Assert.AreEqual(8, result);
    }

    [Test]
    public void FindMaxValue_Returns_Correct_Value_When_Given_Array_Of_Positive_Integers_In_Ascending_Order()
    {
        //Arrange

        var ascendingNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        //Act

        var result = _sut.FindMaxValue(ascendingNumbers);

        //Assert

        Assert.AreEqual(8, result);

    }

    [Test]
    public void FindMaxValue_Returns_Correct_Value_When_Given_Array_Of_Positive_Integers_In_Random_Order()
    {
        //Arrange

        var randomNumbers = new[] { 4, 7, 1, 3, 5, 8, 2, 6 };

        //Act

        var result = _sut.FindMaxValue(randomNumbers);

        //Assert

        Assert.AreEqual(8, result);

    }

    [Test]
    public void FindMaxValue_Returns_Correct_Value_When_Given_Array_Of_Negative_Integers_In_Random_Order()
    {
        //Arrange

        var negativeAndPositiveNumbers = new[] { -4, 7, 1, 3, 5, -8, -2, 6 };

        //Act

        var result = _sut.FindMaxValue(negativeAndPositiveNumbers);

        //Assert

        Assert.AreEqual(7, result);

    }

    [Test]
    public void FindMaxValue_Returns_Correct_Value_When_Given_Array_Of_One_Integer()
    {
        //Arrange

        var oneNumberArray = new[] { 6 };

        //Act

        var result = _sut.FindMaxValue(oneNumberArray);

        //Assert

        Assert.AreEqual( 6, result);
    }

    [Test]
    public void FindMaxValue_Throws_An_Error_When_Given_An_Empty_Array()
    {
        //Arrange

        var emptyArray = Array.Empty<int>();

        //Act

        //Assert

        Assert.Throws<InvalidOperationException>(() => _sut.FindMaxValue(emptyArray));
    }


    //Find TopN

    //Find Max Values Test
    [Test]
    public void FindTopNValues_Returns_Correct_Values_When_Given_Array_Of_Positive_Integers_In_Descending_Order()
    {
        //Arrange

        var descendingNumbers = new[] { 8, 7, 6, 5, 4, 3, 2, 1 };

        //Act

        var expectedResult = new[] { 8, 7, 6 };

        var result = _sut.FindTopNValues(descendingNumbers, 3);

        //Assert

        Assert.AreEqual(result[0], expectedResult[0]);
        Assert.AreEqual(result[1], expectedResult[1]);
        Assert.AreEqual(result[2], expectedResult[2]);
    }

    [Test]
    public void FindTopNValues_Returns_Correct_Values_When_Given_Array_Of_Positive_Integers_In_Ascending_Order()
    {
        //Arrange

        var ascendingNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        //Act

        var expectedResult = new[] { 8, 7, 6 };

        var result = _sut.FindTopNValues(ascendingNumbers, 3);

        //Assert

        Assert.AreEqual(result[0], expectedResult[0]);
        Assert.AreEqual(result[1], expectedResult[1]);
        Assert.AreEqual(result[2], expectedResult[2]);

    }

    [Test]
    public void FindTopNValues_Returns_Correct_Values_When_Given_Array_Of_Positive_Integers_In_Random_Order()
    {
        //Arrange

        var randomNumbers = new[] { 4, 7, 1, 3, 5, 8, 2, 6 };

        //Act

        var expectedResult = new[] { 8, 7, 6 };

        var result = _sut.FindTopNValues(randomNumbers, 3);

        //Assert

        Assert.AreEqual(result[0], expectedResult[0]);
        Assert.AreEqual(result[1], expectedResult[1]);
        Assert.AreEqual(result[2], expectedResult[2]);

    }

    [Test]
    public void FindTopNValues_Returns_Correct_Values_When_Given_Array_Of_Negative_Integers_In_Random_Order()
    {
        //Arrange

        var positiveAndNegativeNumbers = new[] { -4, 7, -1, -3, 5, -8, -2, -6 };

        //Act

        var expectedResult = new[] { 7, 5, -1 };

        var result = _sut.FindTopNValues(positiveAndNegativeNumbers, 3);

        //Assert

        Assert.AreEqual(result[0], expectedResult[0]);
        Assert.AreEqual(result[1], expectedResult[1]);
        Assert.AreEqual(result[2], expectedResult[2]);

    }

    [Test]
    public void FindTopNValues_Returns_Correct_Values_When_Given_Array_Of_One_Integer()
    {
        //Arrange

        var oneNumberArray = new[] { 6 };

        //Act

        var expectedResult = new[] { 6 };

        var result = _sut.FindTopNValues(oneNumberArray, 1);

        //Assert

        Assert.AreEqual(result[0], expectedResult[0]);

    }

    [Test]
    public void FindTopNValues_Throws_An_Error_When_Given_Array_Of_One_Integer_And_N_Value_Of_More_Than_One()
    {
        //Arrange

        var oneNumberArray = new[] { 6 };

        //Act

        //Assert

        Assert.Throws<ArgumentOutOfRangeException>(() => _sut.FindTopNValues(oneNumberArray, 2));
    }
}
