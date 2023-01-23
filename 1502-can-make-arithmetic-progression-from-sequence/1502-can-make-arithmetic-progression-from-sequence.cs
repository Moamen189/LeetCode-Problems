public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        
        for(int i = 1 ; i < arr.Length -1 ; i ++){
            if ((arr[i] - arr[i-1]) != (arr[i+1] - arr[i]))
            {
                return false;
            }
        }
        return true;
    }
}