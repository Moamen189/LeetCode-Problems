public class Solution {
    public int ShortestSubarray(int[] nums, int k) {
        int n = nums.Length;
        long[] prefixSums = new long[n + 1];
        
      
        for (int i = 0; i < n; i++)
        {
            prefixSums[i + 1] = prefixSums[i] + nums[i];
        }

        int minLength = int.MaxValue;
        var deque = new LinkedList<int>();

        for (int i = 0; i < prefixSums.Length; i++)
        {
           
            while (deque.Count > 0 && prefixSums[i] - prefixSums[deque.First.Value] >= k)
            {
                minLength = Math.Min(minLength, i - deque.First.Value);
                deque.RemoveFirst();
            }

       
            while (deque.Count > 0 && prefixSums[i] <= prefixSums[deque.Last.Value])
            {
                deque.RemoveLast();
            }

            
            deque.AddLast(i);
        }

        return minLength == int.MaxValue ? -1 : minLength;
    }
}