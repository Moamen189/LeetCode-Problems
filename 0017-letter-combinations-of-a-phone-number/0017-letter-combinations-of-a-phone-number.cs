public class Solution {
    public IList<string> LetterCombinations(string digits) {
       IList<string> res = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return res;
            }
         
       
            Dictionary<Char, char[]> lettersMap = new Dictionary<Char, char[]>();
            lettersMap.Add('1', null);
            lettersMap.Add('2', new[] { 'a', 'b', 'c' });
            lettersMap.Add('3', new[] { 'd', 'e', 'f' });
            lettersMap.Add('4', new[] { 'g', 'h', 'i' });
            lettersMap.Add('5', new[] { 'j', 'k', 'l' });
            lettersMap.Add('6', new[] { 'm', 'n', 'o' });
            lettersMap.Add('7', new[] { 'p', 'q', 'r', 's' });
            lettersMap.Add('8', new[] { 't', 'u', 'v' });
            lettersMap.Add('9', new[] { 'w', 'x', 'y', 'z' });
            lettersMap.Add('0', null);
           

           res.Add("");
            foreach (char d in digits)
            {
                IList<string> next = new List<string>();
                var letterList = lettersMap.Where(x => x.Key == d).FirstOrDefault().Value;
                foreach (char letter in letterList)
                {
                    foreach (string s in res)
                    {
                        next.Add(s + letter);
                    }
                }
                res = next;
            }

            return res;

    }
}