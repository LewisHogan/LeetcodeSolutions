namespace _206_ReverseLinkedList;
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode previousNode = null;
        ListNode currentNode = head;

        while (currentNode != null)
        {
            var next = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = next;
        }

        return previousNode;
    }
}
