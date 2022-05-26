namespace _217_ContainsDuplicate;
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var encounteredNumbers = new HashSet<int>();
        foreach (var number in nums) {
            if (!encounteredNumbers.Add(number)) return true;
        }

        return false;
    }
}
