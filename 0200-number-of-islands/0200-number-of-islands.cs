public class Solution {
    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length ==0)
            return 0;
        
        var count =0;
        var yMax= grid.Length;
        var xMax= grid[0].Length;
        
        for(var x=0; x <xMax; x++)
        for(var y=0; y <yMax; y++)
            if(grid[y][x] =='1'){
                
                Island(x,y);
                count++;
            }
        return count;
        
        void Island(int x,int y){
             if (x < 0 || x >= xMax || y < 0 || y >= yMax || grid[y][x] != '1')
                return;

            grid[y][x] = '0';
            Island(x, y + 1);
            Island(x, y - 1);
            Island(x + 1, y);
            Island(x - 1, y);
        }


        
    }
}