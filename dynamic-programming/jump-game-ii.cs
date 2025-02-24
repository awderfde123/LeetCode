public class Solution {
    public int Jump(int[] nums) {
            if(nums.Length <=1)
            {
              return 0;
            }
                int a = 0;
                int count = 0;
                while (a + nums[a] <= nums.Length)
                {
                    if (a + nums[a] >= nums.Length - 1)
                        return count + 1;
                    int temp = a + nums[a];
                     for (int i = a + nums[a]; i >= a+1; i--)
                    {
                        if ( i + nums[i] > temp + nums[temp])
                        {
                            temp = i;
                        }
                    }
                    a = temp;
                    count++;
                }
                return count + 1;
    }
}