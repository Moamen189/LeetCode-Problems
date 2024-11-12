public class Solution {
    public int[] MaximumBeauty(int[][] items, int[] queries) {
        
        Array.Sort(items, (a,b)=>{return a[0]-b[0];});

     
        List<int[]> sorted = new List<int[]>();
        sorted.Add(items[0]);
        for (int i = 1; i < items.Length; i++){
            if (items[i][1] < sorted[^1][1]) continue;
            if (items[i][0] == sorted[^1][0]) {sorted[^1][1] = items[i][1]; continue;}
            sorted.Add(items[i]);
        }

     
        int[] indexes = new int[queries.Length];
        for (int i = 0; i < indexes.Length; i++) indexes[i] = i;
        Array.Sort(queries, indexes);

        
        int cur = 0;
        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++){
        
            while (cur < sorted.Count && sorted[cur][0] <= queries[i]) cur++;
        
            result[indexes[i]] = cur > 0 ? sorted[cur-1][1] : 0;
        }

        return result;
    }
}