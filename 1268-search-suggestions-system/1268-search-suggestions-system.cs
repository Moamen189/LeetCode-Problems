public class Solution
{
	public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
	{
		var lists = new List<IList<string>>();
		var list = products.ToList().OrderBy(w => w).ToList();
		for (int i = 0; i < searchWord.Length; i++)
		{
			list = list.Where(w => w.StartsWith(searchWord.Substring(0, i+1))).ToList();
			lists.Add(list.Take(3).ToList());
		}
		return lists;
	}
}