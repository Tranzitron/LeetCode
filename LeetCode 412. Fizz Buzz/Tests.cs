namespace LeetCode_412._Fizz_Buzz;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        var n = 3;

        var actualOutput = _solution.FizzBuzz(n);
        var expectedOutput = new[] { "1", "2", "Fizz" };

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example2()
    {
        var n = 5;

        var actualOutput = _solution.FizzBuzz(n);
        var expectedOutput = new[] { "1", "2", "Fizz", "4", "Buzz" };

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example3()
    {
        var n = 15;

        var actualOutput = _solution.FizzBuzz(n);
        var expectedOutput = new[]
            { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

        Assert.Equal(expectedOutput, actualOutput);
    }

    // [Fact]
    // public void TestCase74()
    // {
    //     var n = 10;
    //
    //     var actualOutput = _solution.FizzBuzz(n);
    //     var expectedOutput = new[] {"1","2","Fizz"};
    //
    //     Assert.Equal(expectedOutput, actualOutput);
    // }
}