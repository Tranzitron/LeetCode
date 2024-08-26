namespace LeetCode_66._Plus_One;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        return AddUp(digits.Length - 1, ref digits);
    }

    private int[] AddUp(int index, ref int[] digits)
    {
        if (digits[index] < 9)
        {
            digits[index]++;
            return digits;
        }

        digits[index] = 0;
        if (index > 0)
        {
            AddUp(index - 1, ref digits);
        }
        else
        {
            Array.Resize(ref digits, digits.Length + 1);
            Array.Copy(digits, 0, digits, 1, digits.Length - 1);
            digits[0] = 1;
        }

        return digits;
    }
}