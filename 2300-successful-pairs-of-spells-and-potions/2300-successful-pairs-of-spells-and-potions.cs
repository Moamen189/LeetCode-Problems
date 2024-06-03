public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        
        Array.Sort(potions);

        var result = new List<int>();

        for(int i=0; i < spells.Length; i++){

            int start = 0;
            int end = potions.Length - 1;

            while(start <= end){

                int mid = start + (end - start)/2;

                long currStrength = (long)potions[mid]* (long)spells[i];

                if( currStrength >= success){

                    end = mid - 1;
                }
                else{

                    start = mid + 1;
                }
            }

            result.Add(potions.Length - start);
        }
        

        return result.ToArray();
    }
}