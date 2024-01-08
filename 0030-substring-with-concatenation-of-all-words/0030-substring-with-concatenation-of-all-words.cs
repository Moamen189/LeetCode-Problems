public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
         IList<int> result = new List<int>();
        
        if (string.IsNullOrEmpty(s) || words == null || words.Length == 0)
        {
            return result;
        }

        int wordLength = words[0].Length;
        int totalWords = words.Length;
        int totalLength = wordLength * totalWords;

        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }

        for (int i = 0; i <= s.Length - totalLength; i++)
        {
            Dictionary<string, int> seenWords = new Dictionary<string, int>();
            int j = 0;

            while (j < totalWords)
            {
                int currentWordIndex = i + j * wordLength;
                string currentWord = s.Substring(currentWordIndex, wordLength);

                if (!wordFrequency.ContainsKey(currentWord))
                {
                    break;
                }

                if (seenWords.ContainsKey(currentWord))
                {
                    seenWords[currentWord]++;
                }
                else
                {
                    seenWords[currentWord] = 1;
                }

                if (seenWords[currentWord] > wordFrequency[currentWord])
                {
                    break;
                }

                j++;
            }

            if (j == totalWords)
            {
                result.Add(i);
            }
        }

        return result;
    }
}