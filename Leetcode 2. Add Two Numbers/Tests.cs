namespace Leetcode_2._Add_Two_Numbers;

public class Tests
{
    private readonly Solution _solution = new();


    [Fact]
    public void Example1()
    {
        var l1 = CreateNodes(new[] { 2, 4, 3 });
        var l2 = CreateNodes(new[] { 5, 6, 4 });

        var actualOutput = _solution.AddTwoNumbers(l1, l2);
        var expectedOutput = CreateNodes(new[] { 7, 0, 8 });

        Assert.Equal(expectedOutput.ToString(), actualOutput.ToString());
    }

    [Fact]
    public void Example2()
    {
        var l1 = CreateNodes(new[] { 0 });
        var l2 = CreateNodes(new[] { 0 });

        var actualOutput = _solution.AddTwoNumbers(l1, l2);
        var expectedOutput = CreateNodes(new[] { 0 });

        Assert.Equal(expectedOutput.ToString(), actualOutput.ToString());
    }

    [Fact]
    public void Example3()
    {
        var l1 = CreateNodes(new[] { 9, 9, 9, 9, 9, 9, 9 });
        var l2 = CreateNodes(new[] { 9, 9, 9, 9 });

        var actualOutput = _solution.AddTwoNumbers(l1, l2);
        var expectedOutput = CreateNodes(new[] { 8, 9, 9, 9, 0, 0, 0, 1 });

        Assert.Equal(expectedOutput.ToString(), actualOutput.ToString());
    }

    [Fact]
    public void TestCase16()
    {
        var l1 = CreateNodes(new[] { 2, 4, 9 });
        var l2 = CreateNodes(new[] { 5, 6, 4, 9 });

        var actualOutput = _solution.AddTwoNumbers(l1, l2);
        var expectedOutput = CreateNodes(new[] { 7, 0, 4, 0, 1 });

        Assert.Equal(expectedOutput.ToString(), actualOutput.ToString());
    }

    [Fact]
    public void TestCase32()
    {
        var l1 = CreateNodes(new[] { 9 });
        var l2 = CreateNodes(new[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 });

        var actualOutput = _solution.AddTwoNumbers(l1, l2);
        var expectedOutput = CreateNodes(new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });

        Assert.Equal(expectedOutput.ToString(), actualOutput.ToString());
    }

    [Fact]
    public void TestCase1565()
    {
        var l1 = CreateNodes(new[]
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });
        var l2 = CreateNodes(new[] { 5, 6, 4 });

        var actualOutput = _solution.AddTwoNumbers(l1, l2);
        var expectedOutput = CreateNodes(new[]
            { 6, 6, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 });

        Assert.Equal(expectedOutput.ToString(), actualOutput.ToString());
    }

    /**
     * Creates a listnode in order of the int passed as parameters
     * 
     * @param nums ok
     * @return the ListNode in order
     */
    private static ListNode CreateNodes(IReadOnlyCollection<int> nums)
    {
        var nodes = new List<ListNode>();

        foreach (var num in nums)
        {
            var listNode = new ListNode
            {
                val = num
            };
            nodes.Add(listNode);
        }

        for (var i = 0; i < nums.Count; i++)
            if (i < nums.Count - 1)
                nodes[i].next = nodes[i + 1];

        return nodes[0];
    }
}