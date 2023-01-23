public class Solution {
    public bool IsHappy(int n) {
          HashSet<int> numbers = new HashSet<int>();
        
        while(true){
            int tmp = 0;
            while(n > 0){
                tmp += (int)Math.Pow((n%10), 2);
                n/=10;
            }
            
            n = tmp;
            if(n == 1){
                break;
            }else if(numbers.Contains(n)){
                return false;
            }
            numbers.Add(n);
        }
        return true;
    }
}