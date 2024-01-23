using System.Numerics;
using System.Text;

namespace Leetcode_2._Add_Two_Numbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var n1 = ListNodeToNumber(l1);
        var n2 = ListNodeToNumber(l2);
        var sum = n1 + n2;
        return NumberToListNode(sum);
    }


    public BigInteger ListNodeToNumber(ListNode listNode)
    {
        if (listNode == null) throw new ArgumentException();

        long val = listNode.val;
        var next = listNode.next;
        var result = new StringBuilder();
        result.Append(val);

        while (next != null)
        {
            result.Append(next.val);
            next = next.next;
        }

        return BigInteger.Parse(Reverse(result.ToString()));
    }

    public ListNode NumberToListNode(BigInteger number)
    {
        if (number.Sign == -1) throw new ArgumentException("Input must be a non-negative long");

        var dummyHead = new ListNode();
        var current = dummyHead;

        // Convert the number to a string to iterate over its digits
        var numberStr = number.ToString();

        for (var i = numberStr.Length - 1; i >= 0; i--)
        {
            var digit = (int)char.GetNumericValue(numberStr[i]);
            current.next = new ListNode(digit);
            current = current.next;
        }

        return dummyHead.next;
    }

    private static string Reverse(string s)
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}