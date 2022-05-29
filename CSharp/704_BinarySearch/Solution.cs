namespace _704_BinarySearch;
public class Solution
{
    public int Search(int[] nums, int target)
    {
        var lowIndex = 0;
        var highIndex = nums.Length - 1;

        while (lowIndex <= highIndex)
        {
            var centerIndex = (lowIndex + highIndex) / 2;
            if (nums[centerIndex] == target) return centerIndex;

            if (nums[centerIndex] < target) lowIndex = centerIndex + 1;
            else highIndex = centerIndex - 1;
        }

        return -1;
    }
}
