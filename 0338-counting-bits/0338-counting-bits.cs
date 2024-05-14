public class Solution {
public int[] CountBits(int num)
{
   int[] result = new int[num + 1];
   for(int i = 0; i <= num; i ++)
   {
	  result[i] = result[i / 2] + (i % 2);
   }        
   return result;
}
}