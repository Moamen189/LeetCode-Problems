public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        int counter=0;
        List<int[]> sorted=intervals.ToList().OrderBy(x=>x[0]).ThenBy(x=>x[1]).ToList();

        int len=intervals.Length;
        int[] prev=null;
        
        for(int i=0;i<len;i++)
        {
            if(prev==null || prev[1]<=sorted[i][0])
                prev=sorted[i];
            else
            {
                counter++;
                if(prev[1]>sorted[i][1])
                    prev=sorted[i];
            }
        }

        return counter;
    }
}