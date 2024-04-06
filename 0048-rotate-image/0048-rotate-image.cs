public class Solution {
    public void Rotate(int[][] mtx) {
         var l = 0;
        var r = mtx.Length - 1;

        while (l < r)
        {
            for (var i = 0; i < r - l; i++)
            {
                var topLeft = mtx[l][l + i];
        
                mtx[l][l + i] = mtx[r - i][l];

                mtx[r - i][l] = mtx[r][r - i];

                mtx[r][r - i] = mtx[l + i][r];

                mtx[l + i][r] = topLeft;
            }
            r--;
            l++;
        }
    }
}