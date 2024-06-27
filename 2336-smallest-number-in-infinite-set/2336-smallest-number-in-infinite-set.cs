public class SmallestInfiniteSet
{
    SortedSet<int> sortedSet;
    public SmallestInfiniteSet()
    {
        sortedSet = new SortedSet<int>();
        for (int i = 1; i <= 1000; i++)
            sortedSet.Add(i);
    }

    public int PopSmallest()
    {
        int min = sortedSet.Min;
        sortedSet.Remove(min);
        return min;
    }

    public void AddBack(int num)
    {
        sortedSet.Add(num);
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */