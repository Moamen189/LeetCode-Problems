public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> st = new();

        foreach(var x in asteroids){
            if(x>0){
                st.Push(x);
            }else{
                while(st.Count!=0 && st.Peek() > 0 && st.Peek()<-x){
                    st.Pop();
                }

                if(st.Count!=0 && st.Peek() == -x){
                    st.Pop();
                }else if(st.Count == 0 || st.Peek() < 0){
                    st.Push(x);
                }
            }
        }
        var ans = st.Reverse().ToArray();
        return ans;
    }
}