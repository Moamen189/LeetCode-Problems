public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        var c = 0;
	var j = 0;
	for (var i = 0; i < s1.Length; i++) {
		if (s1[i] == s2[i]) continue;
		if (++c > 2 || c == 2 && (s1[i] != s2[j] || s1[j] != s2[i])) return false;
		j = i;
	}
	return c != 1;
    }
}