 public class Solution
    {
        private class TrieNode
        {
            public bool HasValue;
            public readonly Dictionary<char, TrieNode> Next = new Dictionary<char, TrieNode>();
        }

        private class Trie
        {
            public TrieNode Root = new TrieNode();

            private void AddValue(TrieNode node, ref string val, int idx)
            {
                if (idx == val.Length)
                {
                    node.HasValue = true;
                    return;
                }

                char c = val[idx];
                TrieNode nextNode = null;

                if (node.Next.ContainsKey(c))
                {
                    nextNode = node.Next[c];
                }
                else
                {
                    nextNode = new TrieNode();
                    node.Next[c] = nextNode;
                }

                AddValue(nextNode, ref val, idx + 1);
            }

            public void AddValue(string val)
            {
                AddValue(Root, ref val, 0);
            }
        }

        private void Dfs(TrieNode node, IList<string> res, StringBuilder sb)
        {
            if (res.Count == 3)
            {
                return;
            }

            if (node.HasValue)
            {
                res.Add(sb.ToString());
            }

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!node.Next.ContainsKey(c))
                {
                    continue;
                }

                sb.Append(c);
                Dfs(node.Next[c], res, sb);
                sb.Remove(sb.Length - 1, 1);

                if (res.Count == 3)
                {
                    return;
                }
            }
        }

        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            IList<IList<string>> res = new List<IList<string>>();
            Trie t = new Trie();
            foreach (var product in products)
            {
                t.AddValue(product);
            }

            TrieNode node = t.Root;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < searchWord.Length; i++)
            {
                var c = searchWord[i];
                sb.Append(c);
                res.Add(new List<string>());

                if (node != null && node.Next.ContainsKey(c))
                {
                    node = node.Next[c];
                    Dfs(node, res[res.Count - 1], sb);
                }
                else
                {
                    node = null;
                }
            }

            return res;
        }
    }