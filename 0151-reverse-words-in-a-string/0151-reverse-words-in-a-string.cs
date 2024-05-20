public class Solution {
    public string ReverseWords(string s) {
        var reversed = s.Split(' ');
        var reverseWordToArray = reversed.Reverse().ToArray();
        return string.Join(" " , reverseWordToArray.Where(x => x != ""));
    }
}


