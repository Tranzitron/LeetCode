namespace LeetCode_66._Plus_One;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        var digits = new[] { 1, 2, 3 };

        var actualOutput = _solution.PlusOne(digits);
        var expectedOutput = new[] { 1, 2, 4 };

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example2()
    {
        var digits = new[] { 4, 3, 2, 1 };

        var actualOutput = _solution.PlusOne(digits);
        var expectedOutput = new[] { 4, 3, 2, 2 };

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example3()
    {
        var digits = new[] { 9 };

        var actualOutput = _solution.PlusOne(digits);
        var expectedOutput = new[] { 1, 0 };

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void TestCase74()
    {
        var digits = new[] { 9, 9 };

        var actualOutput = _solution.PlusOne(digits);
        var expectedOutput = new[] { 1, 0, 0 };

        Assert.Equal(expectedOutput, actualOutput);
    }
}