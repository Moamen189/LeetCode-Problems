public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
          List<int> a = new List<int>(m+n);
        a.AddRange(nums1.Take(m));
        a.AddRange(nums2.Take(n));

        var sorted = a.OrderBy(x=>x).ToList();
        for (int i = 0; i < sorted.Count(); i++) {
            nums1[i] = sorted[i];
        }  
    }
}