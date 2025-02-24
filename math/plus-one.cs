public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> a = new List<int>();
         int curry = 0;
        digits[digits.Count()-1] += 1;
        for(int i = digits.Count()-1 ; i>=0 ; i--)
        {
            if(curry == 1)
            {
                digits[i] += 1;
                curry = 0;
            }
            if(digits[i] == 10)
            {
                digits[i] %= 10;
                curry = 1;
            }
            if(a == null)
                a.Add(digits[i]);
            else
            a.Insert(0,digits[i]);
        }
        if(curry == 1)
            a.Insert(0,1);
        return a.ToArray();
    }
}