using System.Text;

namespace Leetcode_2._Add_Two_Numbers;

public class ListNode
{
    public ListNode next;
    public int val;

    public ListNode()
    {
    }

    public ListNode(int val)
    {
        this.val = val;
    }

    public ListNode(int val, ListNode next)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        var value = val;
        var next = this.next;
        var result = new StringBuilder();
        result.Append(value);

        while (next != null)
        {
            result.Append(next.val);
            next = next.next;
        }

        return result.ToString();
    }
}