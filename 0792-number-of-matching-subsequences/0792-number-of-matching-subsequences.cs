public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {
        int count = 0;
        var wordCount = new Dictionary<string, int>();      
        
        foreach(var word in words)
        {
            if (!wordCount.ContainsKey(word))
                wordCount[word] =0;
            wordCount[word]++;
        }
        
        foreach(var word in wordCount.Keys)
            if (IsSubSequence(s, word))
                count += wordCount[word];
        
        return count;
    }
    
    private bool IsSubSequence(string big, string small)
    {
        int i = 0, j = 0;
        while(i < big.Length && j < small.Length)
            if(big[i++] == small[j])
                j++;
        return j == small.Length;
     
        
    }
}