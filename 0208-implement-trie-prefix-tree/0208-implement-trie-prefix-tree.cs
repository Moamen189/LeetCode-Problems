public class Trie {
    
    private Node Root {get; set;}

    private class Node
    {
        public bool IsWord {get; set;}
        
        public Node[] Children {get; set;}
        
        public char Letter {get; set;}
        
        public Node(char letter)
        {
            Letter = letter;
            Children = new Node[26];
            IsWord = false;
        }
    }
    
    /** Initialize your data structure here. */
    public Trie() {
        Root = new Node('\0');
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        Node current = Root;
        for(int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            if (current.Children[letter - 'a'] == null)
            {
                current.Children[letter - 'a'] = new Node(letter);
            }
            current = current.Children[letter - 'a'];
        }
        current.IsWord = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        Node current = Root;
        for(int i = 0; i < word.Length; i++)
        {
            char letter = word[i];
            if (current.Children[letter - 'a'] == null)
            {
                return false;
            }
            current = current.Children[letter - 'a'];
        }
        return current.IsWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        Node current = Root;
        for(int i = 0; i < prefix.Length; i++)
        {
            char letter = prefix[i];
            if (current.Children[letter - 'a'] == null)
            {
                return false;
            }
            current = current.Children[letter - 'a'];
        }
        return current == null ? false : true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */