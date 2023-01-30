public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] a = s.ToArray();
        char[] b = t.ToArray();

        Array.Sort(a);
        Array.Sort(b);

        return string.Join("", a) == string.Join("", b); 
    }
}