public class Solution {
    public int MaxSubArray(int[] nums) {
            int sum = a(nums);
        if(sum<0)
            return sum;
            int max = nums[0];
            for (int i = 0; i < nums.Count(); i++)
            {
                sum += nums[i];
                sum = Math.Max(0, sum);
                max = Math.Max(sum, max);
            }
            return max;
    }
    int a (int[] nums)
    {
        int max = nums[0];
        for (int i = 0; i < nums.Count(); i++)
        {
            if(nums[i]>0)
                return 0;
            else
                max = Math.Max(nums[i], max);
        }
        return max;
    }
}