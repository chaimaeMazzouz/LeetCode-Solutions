
using Add_Two_Numbers;
using System.Numerics;
using System.Text;
ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    // Convert linked list  to list
    List<int> list1 = new List<int>();
    ListNode L1 = l1;
    List<int> list2 = new List<int>();
    ListNode L2 = l2;
    List<int> current = new List<int>();
    while (L1 != null )
    {
        list1.Add(L1.val);
        L1 = L1.next;
    }
    while (L2 != null)
    {
        list2.Add(L2.val);
        L2 = L2.next;
    }

    BigInteger num1 = 0;
    BigInteger num2 = 0;

    for (int i = 0; i < list1.Count; i++)
    {
        num1 += list1[i] * BigInteger.Pow(10, i);
    }

    for (int i = 0; i < list2.Count; i++)
    {
        num2 += list2[i] * BigInteger.Pow(10, i);
    }
    BigInteger som = (num1 + num2);
    string sum = som.ToString();
    for (int i = 0;i < sum.Length;i++) {
        current.Add(int.Parse(sum[i].ToString()));
    }
    current.Reverse();
    return ConvertListToLinkedList(current);
}

ListNode l2 = new(2, new()
{
    val = 4,
    next = new()
    {
        val = 3,
    }
});
ListNode l1 = new() { val =9 };
//ListNode l2 = new(1, new()
//{
//    val = 9,
//    next = new()
//    {
//        val = 9,
//        next = new()
//        {
//            val = 9,
//            next = new()
//            {
//                val = 9,
//                next = new()
//                {
//                    val = 9,
//                    next = new()
//                    {
//                        val = 9,
//                        next = new()
//                        {
//                            val = 9,
//                            next = new()
//                            {
//                                    val = 9,
//                                    next = new() { val = 9,}
                                
//                            }
//                        }
//                    }
//                }
//            }
//        } 
//    }
//});

ListNode ConvertListToLinkedList(List<int> list)
{
    if (list == null || list.Count == 0)
    {
        return null;
    }

    ListNode head = new ListNode(list[0]);
    ListNode current = head;
    for (int i = 1; i < list.Count; i++)
    {
        current.next = new ListNode(list[i]);
        current = current.next;
    }

    return head;
}

string ConvertLinkedListToString(ListNode head)
{
    if (head == null)
    {
        return "Empty list";
    }

    StringBuilder sb = new StringBuilder();
    ListNode current = head;
    while (current != null)
    {
        sb.Append(current.val);
        sb.Append(" , ");
        current = current.next;
    }

    return sb.ToString();
}


Console.WriteLine("  =>  " + ConvertLinkedListToString(AddTwoNumbers(l1, l2)));