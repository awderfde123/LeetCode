public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Count() == 0) return 0;

    int i = 0;
    for (int j = 1; j < nums.Count(); j++) {
        if (nums[j] != nums[i]) {
            i++;
            nums[i] = nums[j];
        }
    }
    return i + 1;
    }
}