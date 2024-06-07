public class Solution
{
    public int LongestOnes(int[] A, int K) 
    {
        int zeros = 0, start = 0, result = 0;
        for(int end = 0; end < A.Length; end++)
        {
            if(A[end] == 0) zeros++;
            while(zeros > K)
            {
                if(A[start] == 0)
                    zeros--;
                start++;
            }
            
            result = Math.Max(result, end - start + 1);
        }
        
        return result;
    }
}