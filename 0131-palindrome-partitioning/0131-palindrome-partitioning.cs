public class Solution {

    List<IList<string>> res = new List<IList<string>>();

    public IList<IList<string>> Partition(string s)
    {
        if (s == null || s.Length == 0) return null;

        helper(new List<string>(), s, 0);

        return res;
    }

    private void helper(List<string> list, string s, int index) 
    {

        if(index == s.Length)
        {
            res.Add(new List<string>(list));
            return;
        }

        var cur = "";
        for (var i = index; i < s.Length; i++) 
        {
           
            cur = cur + s[i];
            if (isPalindromic(cur))
            {
                list.Add(cur);
                helper(list, s, i + 1);
                list.RemoveAt(list.Count - 1);  
            }
        }
    }

    public bool isPalindromic(string s) 
    {
        return s.SequenceEqual(s.Reverse());  
    }
}