public class Solution {
    public int SubarraySum(int[] nums, int k) {
          Dictionary<int,int> a = new Dictionary<int,int>();
                int sum = 0,count = 0;
                a[sum] = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    if (a.ContainsKey(sum - k))
                        count += a[sum - k];
                   _ = a.ContainsKey(sum) ? a[sum]++ : a[sum] = 1;
                }
                return count;
    }
}