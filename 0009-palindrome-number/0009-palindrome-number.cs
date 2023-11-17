public class Solution {
    public bool IsPalindrome(int x) {

        string strX = x.ToString();

        char[] charArray = strX.ToCharArray();
        Array.Reverse(charArray);
        string reversedStrX = new string(charArray);

        
        return strX == reversedStrX;
}
}