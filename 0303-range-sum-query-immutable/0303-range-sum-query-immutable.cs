public class NumArray
    {
        private long[] _sums;

        public NumArray(int[] nums)
        {
            _sums = new long[nums.Length];
            long s = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                s += nums[i];
                _sums[i] = s;
            }
        }

        public int SumRange(int i, int j)
        {
            if (i == 0)
            {
                return (int)_sums[j];
            }

            return (int)(_sums[j] - _sums[i - 1]);
        }
    }

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */