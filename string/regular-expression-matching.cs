public class Solution {
    public bool IsMatch(string s, string p) {
                           if (String.IsNullOrEmpty(p)) return String.IsNullOrEmpty(s);
                bool firstMatch = !String.IsNullOrEmpty(s) && (s[0] == p[0] || p[0] == '.');
                if (p.Length > 1 && p[1] == '*')
                    return firstMatch && IsMatch(s.Substring(1), p) || IsMatch(s, p.Substring(2));
                return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
    }
}