using Remove_Zero_Sum_Consecutive_Nodes_from_Linked_List;
using System.Collections;
using System.Text;

ListNode RemoveZeroSumSublists(ListNode head)
{
    
    // Convert linked list  to list
    List<int> list = new List<int>();
    ListNode current = head;
    
    while (current != null)
    {
        list.Add(current.val);
        current = current.next;
    }
    
    // Remove Zero Sum Sublists
    var sum = 0;
    List<int> indexs = new List<int>();
    for (int i = 0; i < list.Count; i++)
    {
        sum = list[i];
        if (list[i] == 0)
        {
            indexs.Add(i);
        }
        else {
            for (int j = i + 1; j < list.Count; j++)
            {
                sum += list[j];
                if (sum == 0)
                {
                    for (int k = j; k >= i; k--)
                    {
                        indexs.Add(k);
                    }
                    i = j;
                    break;

                }

            }
        }
        
        

    }
    indexs.Sort();
    indexs.Reverse();
    for (int i = 0; i < indexs.Count; i++)
    {
        var indexV= indexs[i];
        list.RemoveAt(indexV);
    }

    // convert list to linked list
    ListNode head2 = ConvertListToLinkedList(list);

    return head2;
}

//ListNode tail = new ListNode(2);
//ListNode node4 = new ListNode(-3, tail);
//ListNode node3 = new ListNode(3, node4);
//ListNode node2 = new ListNode(2, node3);
ListNode head = new ListNode(0);


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


Console.WriteLine("  =>  " + ConvertLinkedListToString(RemoveZeroSumSublists(head)));