public class Solution {
    public string GetHint(string secret, string guess) {
           int bull = 0;
        int cow = 0;
        
       int[] countS = new int[10];
        int[] countG = new int[10];
        
        for(int i =0; i< secret.Length; i++)
        {
            if(secret[i] == guess[i])
            {
                bull++;
            }
            else 
            {
                countS[secret[i] - '0']++;
                countG[guess[i] - '0']++;
            }
        }
        
        for(int i =0 ; i<10; i++)
        {
            cow += Math.Min(countS[i], countG[i]);
        }
        
        return String.Format("{0}A{1}B", bull, cow);
    }
}