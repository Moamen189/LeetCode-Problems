public class Solution {
 public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var res = new List<IList<int>>();
        Array.Sort(candidates);

        void f(int targ, int index, IList<int> ls)
        {    
            if (targ == 0)
            {
                res.Add(new List<int>(ls));
                return;
            }
    
            if (targ < 0)
                return;
    
            for (int i = index; i < candidates.Length; i++)
            {
                if (candidates[i] > targ)
                    break;
                
                if (i > index && candidates[i] == candidates[i - 1])
                    continue;

                ls.Add(candidates[i]);
                var temptar = targ - candidates[i];
                f(temptar, i + 1, ls);
                ls.RemoveAt(ls.Count - 1);
            }
        }
    
        f(target, 0, new List<int>());
    
        return res;
    }
}