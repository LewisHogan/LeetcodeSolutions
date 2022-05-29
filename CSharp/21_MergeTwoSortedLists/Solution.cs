namespace _21_MergeTwoSortedLists;
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = null;

        if ((list1?.val ?? int.MaxValue) <= (list2?.val ?? int.MaxValue))
        {
            head = list1;
            list1 = list1?.next;
        }
        else
        {
            head = list2;
            list2 = list2?.next;
        }
        
        var currentNode = head;
        while (list1 != null || list2 != null)
        {
            var list1Val = list1?.val ?? int.MaxValue;
            var list2Val = list2?.val ?? int.MaxValue;
            
            if (list1Val <= list2Val)
            {
                currentNode.next = list1;
                list1 = list1?.next;
            }
            else
            {
                currentNode.next = list2;
                list2 = list2?.next;
            }
            
            currentNode = currentNode?.next;
        }
        
        return head;
    }
}
