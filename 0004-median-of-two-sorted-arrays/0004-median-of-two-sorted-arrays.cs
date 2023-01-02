public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var mediumPositionLeft = (nums1.Length+nums2.Length-1)/2;
        var mediumPositionRight = (nums1.Length+nums2.Length)/2;
        if (mediumPositionLeft<0)
            return 0;
        var currentPosition = 0;
        var index1 = 0;
        var index2 = 0;
        var result = 0.0;
        while (currentPosition<=mediumPositionRight)
        {
            var nextNumber = 0;
            if (index1>=nums1.Length)
            {
                nextNumber = nums2[index2];
                index2++;
            }
            else if (index2>=nums2.Length)
            {
                nextNumber = nums1[index1];
                index1++;
            }
            else if (nums1[index1]<nums2[index2])
            {
                nextNumber = nums1[index1];
                index1++;    
            }
            else
            {
                nextNumber = nums2[index2];
                index2++;
            }
            if (currentPosition==mediumPositionLeft)
                result+=nextNumber;
            if (currentPosition==mediumPositionRight)
                result+=nextNumber;
            
            currentPosition++;
            
        }
        return    result/2.0;    
        
    }
}