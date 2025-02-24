public class Solution {
    public string AddBinary(string a, string b) {
        int c = 0;
        string answer ="";
        int q = a.Length-1,qq = b.Length-1;
        while(q > -1 || qq > -1)
        {
            if(qq == -1 && q != -1) 
            {
                if((int)Char.GetNumericValue(a[q]) +c>1)
                {
                    answer = "0" + answer;
                    c=1;
                    q--;
                }else
                {
                   answer = ((int)Char.GetNumericValue(a[q])+c) + answer;
                    c=0;
                   q--; 
                }
            }
            else if(q == -1 && qq != -1) 
            {
                if((int)Char.GetNumericValue(b[qq]) +c>1)
                {
                    answer = "0" + answer;
                    c=1;
                    qq--;
                }else
                {
                   answer = ((int)Char.GetNumericValue(b[qq])+c) + answer;
                    c=0;
                   qq--; 
                }
            }
            else
            {
                if((int)Char.GetNumericValue(a[q]) + (int)Char.GetNumericValue(b[qq])+c>1)
                {
                    answer = ((int)Char.GetNumericValue(a[q]) + (int)Char.GetNumericValue(b[qq])+c)-2 + answer;
                    c = 1;
                }
                else
                {
                   answer = ((int)Char.GetNumericValue(a[q]) + (int)Char.GetNumericValue(b[qq])+c) + answer;
                    c = 0; 
                }
                q--;
                qq--;
            }
        }
        if(c == 1) answer = c + answer;
        return answer;
    }
}