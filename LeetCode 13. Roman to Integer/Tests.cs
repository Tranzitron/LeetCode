namespace LeetCode_13._Roman_to_Integer;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        var str = "III";

        var actualOutput = _solution.RomanToInt(str);
        var expectedOutput = 3;

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example2()
    {
        var str = "LVIII";

        var actualOutput = _solution.RomanToInt(str);
        var expectedOutput = 58;

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example3()
    {
        var str = "MCMXCIV";

        var actualOutput = _solution.RomanToInt(str);
        var expectedOutput = 1994;

        Assert.Equal(expectedOutput, actualOutput);
    }
}