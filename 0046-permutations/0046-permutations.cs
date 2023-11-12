public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        
            int n = nums.Length;

            if (n == 0)
                return null;
            else if (n == 1)
            {
                // tricky if use List<List<int>>, it would get error, be careful.
                return new List<IList<int>> { new List<int> { nums[0] } };
            }

            int nEnd = nums[n - 1];

            //get the array without the last element
            int[] nums1 = new int[n - 1];

            for (int i = 0; i < n - 1; i++)
                nums1[i] = nums[i];

            // get the permutation of the sub array
            IList<IList<int>> l = Permute(nums1);

            IList<IList<int>> r = new List<IList<int>>();

            List<int> tp;

            // insert the last element to form all permutations
            foreach (List<int> p in l)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    tp = new List<int>(p);  // new list, tricky.
                    tp.Insert(j, nEnd);
                    r.Add(tp);
                }

                p.Add(nEnd);
                r.Add(p);
            }

            return r;
    }
}