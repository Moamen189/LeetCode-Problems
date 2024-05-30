  public class Solution
    {
public int Compress(char[] chars) {
    int n = chars.Length;
    int writeIndex = 0;  // Index to write the next character in the chars array
    int i = 0;

    while (i < n) {
        char currentChar = chars[i];
        int count = 0;

        // Count the number of occurrences of the current character
        while (i < n && chars[i] == currentChar) {
            i++;
            count++;
        }

        // Write the current character to the array
        chars[writeIndex++] = currentChar;

        // Write the count if it's more than 1
        if (count > 1) {
            foreach (char c in count.ToString()) {
                chars[writeIndex++] = c;
            }
        }
    }

    // The writeIndex now points to the length of the compressed array
    return writeIndex;
}
    }