public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    List<bool> childwMax = new List<bool>();
    
    int maxCandies = candies.Max();
    
    for(int i = 0; i < candies.Length; i++)
    {
        
        if(candies[i] + extraCandies >= maxCandies)
        {
            
            childwMax.Add(true);
            
        }
        else
        {
            
            childwMax.Add(false);
            
        }
        
    }
    
    return childwMax;
          
}
    }