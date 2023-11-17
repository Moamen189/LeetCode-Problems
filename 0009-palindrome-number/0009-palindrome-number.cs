public class Solution {
    public bool IsPalindrome(int x) {
// Convert the integer to a string
        string strX = x.ToString();

        // Reverse the string
        char[] charArray = strX.ToCharArray();
        Array.Reverse(charArray);
        string reversedStrX = new string(charArray);

        // Compare the original string with the reversed string
        return strX == reversedStrX;
}
}