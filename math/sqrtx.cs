public class Solution {
    public int MySqrt(int x) {
        long i = 1;
        while(i*i <= x)
            i++;
        return (int)i-1;
    }
}