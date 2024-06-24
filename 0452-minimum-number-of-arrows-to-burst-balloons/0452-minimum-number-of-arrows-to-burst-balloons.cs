public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points,(a,b)=>{
            if(a[1]<b[1])
            {
                return -1;
            }
            if(a[1]>b[1])
            {
                return 1;
            }
            return 0;
        });
        long end = points[0][1];
        int ans = 1;

        foreach(var p in points)
        {
            if(p[0]>end)
            {
                ans++;
                end = p[1];
            }
        }
        return ans;
    }
}