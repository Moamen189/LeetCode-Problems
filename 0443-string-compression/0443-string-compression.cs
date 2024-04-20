  public class Solution
    {
        public int Compress(char[] chars)
        {
            if (chars.Length <= 1)
            {
                return chars.Length;
            }

            int currItem = 0;
            char currentChar = chars[currItem];
            int nextItem = 1;
            int counter = 1;

            while (true)
            {
                if (nextItem > chars.Length)
                {
                    break;
                }

                if (nextItem == chars.Length || chars[nextItem] != currentChar)
                {
                    var prevChar = currentChar;
                    currentChar = chars[Math.Min(nextItem, chars.Length - 1)];

                    if (counter == 1)
                    {
                        chars[currItem++] = prevChar;
                    }
                    else
                    {
                        chars[currItem++] = prevChar;
                        string counterStr = counter.ToString();
                        foreach (var cstr in counterStr)
                        {
                            chars[currItem++] = cstr;
                        }
                    }

                    counter = 1;
                    nextItem++;
                    continue;
                }

                counter++;
                nextItem++;
            }

            return currItem;
        }
    }