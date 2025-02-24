public class Solution {
    public int LengthOfLastWord(string s) {
      string[] ss = s.Trim().Split(" ");
        return ss[ss.Count()-1].Length;
    }
}