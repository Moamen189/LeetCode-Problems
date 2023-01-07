/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int last, int first = 0) {
      if (first == last) return first;
        
        var middle = first + (last - first) / 2;
        
        return IsBadVersion(middle) ? FirstBadVersion(middle,first) :FirstBadVersion(last, middle  +1);
	}
    
}