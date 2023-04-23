public class Solution {
    public IList<string> GenerateParenthesis(int n) 
    {
        List<string> ret = new List <string>();
        
        StringBuilder current = new StringBuilder();;
        void DFS(int remaining, int lCount)
        {
            if(remaining == 0)
            {
				//we can reach the end of the lefts before placing all rights.
				//if so, add all remaining right parens
                var toAdd = new string(')', n*2 - current.Length);
                current.Append(toAdd);
                ret.Add(current.ToString());
                current.Length-= toAdd.Length;
                return;
            }
            
            current.Append("(");
            DFS(remaining-1, lCount + 1);
            current.Length--;
            
            if(lCount > 0)
            {
                current.Append(")");
                DFS(remaining, lCount - 1);
                current.Length--;
            }
        }
        
        DFS(n, 0);
        
        return ret;
    }
}