namespace LeetCode_412._Fizz_Buzz;

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var listString = new string[n];
        for (var i = 1; i <= n; i++)
        {
            var isThree = i % 3 == 0;
            var isFive = i % 5 == 0;
            if (isThree && isFive)
                listString[i - 1] = "FizzBuzz";
            else if (isThree)
                listString[i - 1] = "Fizz";
            else if (isFive)
                listString[i - 1] = "Buzz";
            else
                listString[i - 1] = i.ToString();
        }

        return listString;
    }
}