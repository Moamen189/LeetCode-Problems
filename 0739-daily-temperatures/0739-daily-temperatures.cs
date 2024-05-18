public class Solution {

        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] res = new int[temperatures.Length];
            Stack<int> stack = new Stack<int>();
            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
                {
                    stack.Pop();
                }

                if(stack.Count != 0)
                {
                    res[i] = stack.Peek() - i;
                }
                stack.Push(i);

            }
            return res;
        }
      
}