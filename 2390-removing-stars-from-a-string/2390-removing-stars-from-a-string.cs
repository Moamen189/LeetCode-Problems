public class Solution {
    public string RemoveStars(string s) {
       Stack<char> stack = new Stack<char>();
        foreach  (char ch in s)
        {
            if (ch == '*')
                stack.Pop();
            else
                stack.Push(ch);
        }
        return String.Concat(stack.ToArray().Reverse()); 
    }
}