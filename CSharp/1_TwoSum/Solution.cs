namespace _1_TwoSum;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var firstNumberIndex = 0; firstNumberIndex < nums.Length - 1; firstNumberIndex++)
        {
            for (var secondNumberIndex = firstNumberIndex + 1; secondNumberIndex < nums.Length; secondNumberIndex++)
            {
                if (nums[firstNumberIndex] + nums[secondNumberIndex] == target) return new[] { firstNumberIndex, secondNumberIndex };
            }
        }
        
        // Input constraints confirm that we should never get here
        return new int[] {};
    }
}
