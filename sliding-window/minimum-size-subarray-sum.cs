public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
      int ans = int.MaxValue, b = 0, sum = 0;
                for(int i = 0; i<nums.Length;i++)
                {
                    sum += nums[i];
                    while(sum >= target)
                    {
                        ans = Math.Min(ans, i - b);
                        sum -= nums[b++];
                    }
                }
                return ans == int.MaxValue ? 0 : ans+1;
    }
}