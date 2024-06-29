public class Solution {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            long res = long.MinValue;
            int n=nums1.Length;
            int[][] mat = new int[n][];
            for(int i = 0; i<n; i++)
            {
                mat[i]=new int[] { nums1[i], nums2[i] };
            }

            mat=mat.OrderBy(x => -x[1]).ToArray();

            var pq = new PriorityQueue<int, int>();
            long sum = 0;
            for(int i = 0; i<n; i++)
            {
                sum+=mat[i][0];
                pq.Enqueue(mat[i][0], mat[i][0]);
                if (pq.Count>k)
                {
    
                    sum-=pq.Dequeue();
                }
                if (pq.Count>=k)//must be only equal to k
                {

                    res= Math.Max(res, sum*mat[i][1]);
                }
            }
            return res;
        }

}