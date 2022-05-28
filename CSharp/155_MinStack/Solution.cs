namespace _155_MinStack;
public class MinStack
{
    private int[] backingArray;
    private int nextTopIndex;

    public MinStack()
    {
        backingArray = new int[8];
        nextTopIndex = 0;
    }

    public void Push(int val)
    {
        // O(1) because the doubling cost will be amortised over so many operations
        if (nextTopIndex == backingArray.Length)
        {
            var newBackingArray = new int[backingArray.Length * 2];
            Array.Copy(backingArray, newBackingArray, backingArray.Length);
            backingArray = newBackingArray;
        }

        backingArray[nextTopIndex++] = val;
    }

    public void Pop()
        => nextTopIndex--;
    
    public int Top()
        => backingArray[nextTopIndex - 1];
    
    public int GetMin()
    {
        var min = backingArray[0]; // This will only ever be called when the stack has at least one element

        for (var index = 1; index < nextTopIndex; index++)
        {
            min = Math.Min(min, backingArray[index]);
        }

        return min;
    }
}
