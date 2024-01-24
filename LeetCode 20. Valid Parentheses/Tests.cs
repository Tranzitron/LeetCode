namespace LeetCode_20._Valid_Parentheses;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        var str = "()";

        var actualOutput = _solution.IsValid(str);
        var expectedOutput = true;

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example2()
    {
        var str = "()[]{}";

        var actualOutput = _solution.IsValid(str);
        var expectedOutput = true;

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example3()
    {
        var str = "(]";

        var actualOutput = _solution.IsValid(str);
        var expectedOutput = false;

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void TestCase74()
    {
        var str = "{[]}";

        var actualOutput = _solution.IsValid(str);
        var expectedOutput = true;

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void TestCase80()
    {
        var str = "([)]";

        var actualOutput = _solution.IsValid(str);
        var expectedOutput = false;

        Assert.Equal(expectedOutput, actualOutput);
    }
}