public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        PriorityQueue<int, int> leftQ = new PriorityQueue<int, int>();
        PriorityQueue<int, int> rightQ = new PriorityQueue<int, int>();
        long totCost = 0;
        int l = 0;
        int r = costs.Length - 1;

        for (int i = 0; i < k; i++)
        {
            while (leftQ.Count < candidates && l <= r)
            {
                leftQ.Enqueue(costs[l], costs[l]);
                l++;
            }

            while (rightQ.Count < candidates && r >= l)
            {
                rightQ.Enqueue(costs[r], costs[r]);
                r--;
            }

            int leftV = leftQ.Count > 0 ? leftQ.Peek() : int.MaxValue;
            int rightV = rightQ.Count > 0 ? rightQ.Peek() : int.MaxValue;

            if (leftV <= rightV)
            {
                totCost += leftV;
                leftQ.Dequeue();
            }
            else
            {
                totCost += rightV;
                rightQ.Dequeue();
            }
        }

        return totCost;
    }
}