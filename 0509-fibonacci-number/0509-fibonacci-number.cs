public class Solution {
   public int Fib(int N) {
        if(N == 0) return 0;
        
        int a = 0, b = 1;
        
        for(var i = 2; i < N; i++){
            var c = a + b;
            a = b;
            b = c;
        }
        
        return a + b;
    }
}

