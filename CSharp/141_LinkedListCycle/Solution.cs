namespace _141_LinkedListCycle;
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode currentNode = head;

        HashSet<ListNode> checkedNodes = new HashSet<ListNode>();

        while (currentNode != null)
        {
            if (checkedNodes.Contains(currentNode)) return true;

            checkedNodes.Add(currentNode);
            currentNode = currentNode.next;
        }

        return false;
    }
}
