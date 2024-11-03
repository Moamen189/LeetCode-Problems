public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int num in nums1)
        {
            if (counts.ContainsKey(num))
                counts[num]++;
            else
                counts[num] = 1;
        }

        // List to store the intersection result
        List<int> intersection = new List<int>();
        foreach (int num in nums2)
        {
            if (counts.ContainsKey(num) && counts[num] > 0)
            {
                intersection.Add(num);
                counts[num]--;
            }
        }

        // Convert the list to an array and return
        return intersection.ToArray();
    }
    }
