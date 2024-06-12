public class Solution {
    public int MaxVowels(string s, int k) {
        int maxVol = 0;
        int Vol = 0;
    for(int i = 0; i < s.Length; i++)
	{
		Vol += ("aeiou".IndexOf(s[i]) >= 0 ? 1 : 0);

		if(i - k >= 0)
		{
			Vol -= ("aeiou".IndexOf(s[i - k]) >= 0 ? 1 : 0);                
		}

		maxVol = Math.Max(maxVol, Vol);
	}

	return maxVol;

    }
}