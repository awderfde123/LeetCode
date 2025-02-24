class Solution {
    public String longestCommonPrefix(String[] strs) {
        String a = strs[0];
        for(int x=1;x<=strs.length-1;x++)
        while (strs[x].indexOf(a) != 0)
        {
            a=a.substring(0,a.length()-1);
            if(a.isEmpty())return "";
        }
        return a;
    }
}