public class Solution {
    public long MinEnd(int n, int x) {
        long ans = x;
        while(--n != 0)
        {
            ans = (ans+1) | x;
        }
        return ans;   
    }
}