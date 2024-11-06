public class Solution {
    public bool CanSortArray(int[] nums) 
    {
        if(IsSorted(nums))
            return true;

        var splittedNums = SplitByBits(nums);

        for(int i = 0; i < splittedNums.Count - 1; i++)
        {
            var currentMaxNumber = splittedNums[i].Max();
            var nextMinNumber = splittedNums[i+1].Min();

            if(currentMaxNumber > nextMinNumber)
                return false;
        }

        return true;
    }

    public List<int[]> SplitByBits(int[] nums)
    {
        var result = new List<int[]>();
        
        var prevNumBitsCount = CountBits(nums[0]);
        var tempList = new List<int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if(CountBits(nums[i]) == prevNumBitsCount)
            {
                tempList.Add(nums[i]);
            }   
            else
            {
                result.Add(tempList.ToArray());
                tempList = new List<int>();

                prevNumBitsCount = CountBits(nums[i]);
                tempList.Add(nums[i]);
            }  
        }
        
        result.Add(tempList.ToArray());

        return result;
    }

    public bool IsSorted(int[] nums)
    {
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i] > nums[i + 1])
                return false;
        }

        return true;
    }

    public static int CountBits(int value)
    {
        var valueAsDecimal = Convert.ToString(value, 2);
        int count = 0;

        for(int i = 0; i < valueAsDecimal.Length; i++)
        {
            if(valueAsDecimal[i] == '1')
                count++;
        }
        return count;
    }
}