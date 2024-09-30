public class Solution {
    public int StrStr(string haystack, string needle) {
        for(int a=0; a <= haystack.Length - needle.Length; a++){
            string str = haystack.Substring(a,needle.Length);
            if (needle == str){
                return a;
            }
        }
        return -1;
    }
}