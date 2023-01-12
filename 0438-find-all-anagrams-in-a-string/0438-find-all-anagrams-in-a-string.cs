public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
          var answer = new List<int>();

        if (s.Length < p.Length) return answer;

        var lookup = new int[26];
        var backet = new int[26];
        for (var i = 0 ; i < p.Length; i++) {
            lookup[p[i] - 'a']++;
            backet[s[i] - 'a']++;
        }
        
        var left = 0;
        var right = p.Length - 1;
        
        while (true) {
            var match = true;
            for(var i = 0; i < lookup.Length; i++) {
                if (lookup[i] != backet[i]) {
                    match = false;
                    break;
                }
            }
            
            if (match) {
                answer.Add(left);
            }
            
            left++;
            right++;
            if (right >= s.Length) {
                break;
            }
            
            backet[s[left-1] - 'a']--;
            backet[s[right] - 'a']++;
        }

        return answer;
    }
}