public class Solution {
    public string PredictPartyVictory(string senate) {
        var list = senate.ToCharArray().ToList();
        var index = 0;
        while (true)
        {
            if (list[index] == 'R')
            {
                if (index + 1 < list.Count)
                {
                    var nextIndex = list.IndexOf('D', index + 1);
                    if (nextIndex != -1)
                    {
                        list.RemoveAt(nextIndex);
                        index = (index + 1) % list.Count;
                    }
                    else
                    {
                        nextIndex = list.IndexOf('D', 0, index);
                        if (nextIndex != -1)
                        {
                            list.RemoveAt(nextIndex);
                        }
                        else
                        {
                            return "Radiant";
                        }
                    }
                }
                else
                {
                    var nextIndex = list.IndexOf('D');
                    if (nextIndex != -1)
                    {
                        list.RemoveAt(nextIndex);
                        index = index % list.Count;
                    }
                    else
                    {
                        return "Radiant";
                    }
                }
            }
            else
            {
                if (index + 1 < list.Count)
                {
                    var nextIndex = list.IndexOf('R', index + 1);
                    if (nextIndex != -1)
                    {
                        list.RemoveAt(nextIndex);
                        index = (index + 1) % list.Count;
                    }
                    else
                    {
                        nextIndex = list.IndexOf('R', 0, index);
                        if (nextIndex != -1)
                        {
                            list.RemoveAt(nextIndex);
                        }
                        else
                        {
                            return "Dire";
                        }
                    }
                }
                else
                {
                    var nextIndex = list.IndexOf('R');
                    if (nextIndex != -1)
                    {
                        list.RemoveAt(nextIndex);
                        index = index % list.Count;
                    }
                    else
                    {
                        return "Dire";
                    }
                }
            }
        }
    }
}