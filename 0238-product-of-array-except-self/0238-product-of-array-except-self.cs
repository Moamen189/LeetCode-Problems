public class Solution {
public int[] ProductExceptSelf(int[] nums)
    {
        int all = 1;
        int zc = 0; //Zero Count
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                zc++;
            else
                all = all * nums[i];
        }
        if (zc == 0)
            return nums.Select(i => all / i).ToArray();
        else if (zc == 1)
            return nums.Select(i => (i == 0) ? all : 0).ToArray();
        else
            return new int[nums.Length];
    }
}