//Solution 3 - runtime 105 ms
public class Solution3
{
    public int[] TwoSum(int[] nums, int target)
    {
        int i = 0;
        int[] targetArray = new int[2];
        while (i < nums.Length)
        {
            if (target - nums[i] == nums[i + 1])
            {
                targetArray[0] = i;
                targetArray[1] = i + 1;
                break;
            }
            i = i + 1;
        }
        return targetArray;
    }

}