
//Solution 1 runtime 135 ms
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int i = 0;
        int[] targetArray = new int[2];
        while (i < nums.Length)
        {
            int firstPossibleNumber = target - nums[i];
            int secondPossibleNumber = target - nums[i + 1];
            if (firstPossibleNumber + secondPossibleNumber == target)
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
