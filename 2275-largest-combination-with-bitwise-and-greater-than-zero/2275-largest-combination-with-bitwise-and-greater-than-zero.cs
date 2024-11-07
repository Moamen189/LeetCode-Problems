public class Solution {
    public int LargestCombination(int[] candidates) 
    {
        var carriage = 1;
        var counter = 0;
        var result = 1;

        for(var i = 0; i < 27; i++)
        {
            for(var j = 0; j < candidates.Length; j++)
            {
                if((carriage & candidates[j]) > 0)
                {
                    counter++;
                }
            }

            if(counter > result)
            {
                result = counter;
            }

            carriage <<= 1;
            counter = 0;
        }
        
        return result;
    }
}