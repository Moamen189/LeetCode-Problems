public class Solution {
    public string FreqAlphabets(string s) {
Stack<string> chars = new Stack<string>();
	foreach(var c in s)
	{
		if(c == '#')
		{
			string pop1 = chars.Pop(), pop2 = chars.Pop();
			chars.Push(pop2+pop1); 
		}
		else
		{
			chars.Push(c.ToString());
		}
	}

	return string.Join("", chars.Reverse().Select(x => (char)(int.Parse(x) + 'a' - 1)));
    }
}