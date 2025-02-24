public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for(int i = 0 ; i<nums.Count();i++)
        {
            if(nums[i]>=target)
            {
                return i;
            }
        }
        return nums.Count();
    }
}