public class Solution {
    public int SubtractProductAndSum(int n) {
        int sum =0;
        int pred =1;
        while (n>0){
           int d = n %10;
            sum+=d;
            pred*=d;
            n = n /10 ;
        }
        
        return (pred - sum);
        
    }
}