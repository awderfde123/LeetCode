class Solution {
    public double findMedianSortedArrays(int[] nums1, int[] nums2) {
        double num1=0,num2=0;
        int[] a = new int[nums1.length + nums2.length];
		System.arraycopy(nums1, 0, a, 0, nums1.length);
		System.arraycopy(nums2, 0, a, nums1.length, nums2.length);
        Arrays.sort(a);
        if(a.length%2!=0)
        {
            return a[a.length/2];
        }
        else
            num1 = a[(a.length/2)-1];
            num2 = a[a.length/2];
        return (num1+num2)/2;
    }
}