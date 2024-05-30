public class Solution 
{
    public int MinReorder(int n, int[][] connections) 
    {
        IList<IList<int>> adjList = new List<IList<int>>();
        HashSet<string> edges = new HashSet<string>();
        
        for(int i=0;i<n;i++)
            adjList.Add(new List<int>());
        
        foreach(var con in connections)
        {
            edges.Add($"{con[0]},{con[1]}");
            adjList[con[0]].Add(con[1]);
            adjList[con[1]].Add(con[0]);
        }
        
        int[] visited = new int[n];
        int edgCnt=0;
        Dfs(adjList,0,visited,edges,ref edgCnt);
        return edgCnt;
    }
    
    private void Dfs(IList<IList<int>> adjList,int node,int[] visited, HashSet<string> edges, ref int edgCnt)
    {
        if(visited[node]==1)
            return;
        
        visited[node]=1;
        
        foreach(var n in adjList[node])
        {
            if(visited[n]==1)
                continue;
            
            if(!edges.Contains($"{n},{node}"))
                edgCnt++;
            
            Dfs(adjList,n,visited,edges,ref edgCnt);
        }
    }
}