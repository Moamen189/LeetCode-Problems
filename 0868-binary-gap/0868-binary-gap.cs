public class Solution {
    public int BinaryGap(int N) {
        int i1 = 0;  // current
        int i2 = 0;  // last 1
        int max = 0;
        while (N > 0)
        {
            int temp = N % 2; // temp = N & 1 ;
            N = N / 2; // N = N >> 1 ;
            i1++;

            if (temp == 1)
            {
                if (i2 != 0)
                {
                    max = max > i1 - i2 ? max : i1 - i2;
                }
                i2 = i1;
            }            
        }
        return max;
    }
}