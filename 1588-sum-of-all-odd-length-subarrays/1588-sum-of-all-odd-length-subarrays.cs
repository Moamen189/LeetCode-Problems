public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int result =0;
        for (int i =0; i < arr.Length; i++){
             for (int m =i; m < arr.Length; m += 2){
                 
                  for (int s = i; s <= m; s++){
                      
                 result += arr[s];
            
        }
        }
        }
        
        return result;
    }
}