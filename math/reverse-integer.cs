public class Solution {
    public int Reverse(int x) {
        try{
        string temp = Math.Abs(x).ToString();
        string answer = "";
        for(int i = temp.Length-1 ; i>=0 ; i--)
        {
            answer += $"{temp[i]}";
        }
        
        return x>0 ? int.Parse(answer) : 0 - int.Parse(answer);
        }catch(Exception e)
        {
            return 0;
        }
    }
}