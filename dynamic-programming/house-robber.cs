public class Solution {
    public int Rob(int[] nums) {
        int L1=0,L2=0;
        for(int i = 0; i<nums.Length;i++)
        {
            if(i%2==0)
                L1 = Math.Max(L1+nums[i],L2);
            else
                L2 = Math.Max(L2+nums[i],L1);
        }
        return L1>L2?L1:L2;
    }
}