//Solution 2 runtime 148 ms
public class Solution2
{
    public int[] TwoSum(int[] nums, int target)
    {
        int i = 0;
        int[] targetArray = new int[2];
        while (i < nums.Length)
        {
            if (nums[i] + nums[i + 1] == target)
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