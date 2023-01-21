public class Solution {
    public int HammingWeight(uint n) {
        int bit = 0;
       
            while(n != 0){
                 n &= n - 1;
                bit++;
            }
        
        return bit;
    }
}