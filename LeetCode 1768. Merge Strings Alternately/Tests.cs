namespace LeetCode_1768._Merge_Strings_Alternately;

public class Tests
{
    private readonly Solution _solution = new();

    [Fact]
    public void Example1()
    {
        var word1 = "abc";
        var word2 = "pqr";

        var actualOutput = _solution.MergeAlternately(word1, word2);
        var expectedOutput = "apbqcr";

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example2()
    {
        var word1 = "ab";
        var word2 = "pqrs";

        var actualOutput = _solution.MergeAlternately(word1, word2);
        var expectedOutput = "apbqrs";

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void Example3()
    {
        var word1 = "abcd";
        var word2 = "pq";

        var actualOutput = _solution.MergeAlternately(word1, word2);
        var expectedOutput = "apbqcd";

        Assert.Equal(expectedOutput, actualOutput);
    }
}