public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
         var list = new List<IList<int>>();

            Backtrack(list, new List<int>(), k, n, 0, 1);

            return list;
    }
    
    void Backtrack(List<IList<int>> list, List<int> temp, int k, int n, int count, int start)
        {
            if(temp.Count == k && temp.Sum() == n) list.Add(new List<int>(temp));

            for (var i = count; i < k; i++)
            {
                for (var j = start; j < 10; j++)
                {
                    temp.Add(j);

                    Backtrack(list, temp, k, n, i + 1, j + 1);

                    temp.RemoveAt(temp.Count - 1);
                }
            }
        }
}