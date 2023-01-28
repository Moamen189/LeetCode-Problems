public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
          var os = new List<char>(order.ToCharArray());

            for (var j = 0; j < words.Length; j++)
            {
                var ws = words[j].ToCharArray();

                for (var i = 0; i < ws.Length; i++)
                    ws[i] = Convert.ToChar('a' + os.IndexOf(words[j][i]));

                words[j] = new string(ws);
            }

            return words.OrderBy(w => w).ToArray().SequenceEqual(words);
    }
}