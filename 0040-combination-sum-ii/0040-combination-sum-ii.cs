public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        List<IList<int>> res = new List<IList<int>>();
        Array.Sort(candidates);
        dfs(0, target, new List<int>(), res, candidates);
        return res;
    }
    
    private void dfs(int idx, int target, List<int> curr, List<IList<int>> res, int[] candidates)
    {
        if(target == 0)
        {
            res.Add(new List<int>(curr));
        }
        else
        {
            for(int i = idx; i < candidates.Length; i++)
            {
                if(i > idx && candidates[i-1] == candidates[i]) continue;
                if(target-candidates[i] < 0) break;
                curr.Add(candidates[i]);
                dfs(i+1, target-candidates[i], curr, res, candidates);
                curr.RemoveAt(curr.Count-1);
            }
        }
    }
}