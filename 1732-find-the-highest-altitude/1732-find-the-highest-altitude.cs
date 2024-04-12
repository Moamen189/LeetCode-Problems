public class Solution {
    public int LargestAltitude(int[] gain) {
        int HighAltitude = 0;
        int InitAltitude = 0;
        
        foreach(var g in gain){
            InitAltitude+=g;
            HighAltitude = Math.Max(HighAltitude,InitAltitude);
        }
        return HighAltitude;

    }
}