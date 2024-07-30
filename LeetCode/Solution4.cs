//Solution 4 runtime 133 ms
public class Solution4
{
    public int[] TwoSum(int[] nums, int target)
    {
        int i = 0;
        int[] targetArray = new int[2];
        while (i < nums.Length)
        {
            if (target - nums[i] == nums[i + 1]) break;
            i = i + 1;
        }
        return new int[] { i, i + 1 };
    }
}