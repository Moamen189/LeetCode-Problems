public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        int count = 0;
        var group = arr.GroupBy(x => x, (_, items) => {
             count++;
            return items.Count();
         });
        var num = group.Distinct().Count();
         return num == count;
    }
}