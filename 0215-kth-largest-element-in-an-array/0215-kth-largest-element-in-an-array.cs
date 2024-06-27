public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var pq = new PriorityQueue<int, int>();

        foreach (var val in nums)
        {
            pq.Enqueue(val, val);

            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        return pq.Peek();
    }
}