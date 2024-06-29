public class Solution {

    public long score;

    public Solution(){
        this.score = 0;
    }

    public long MaxScore(int[] nums1, int[] nums2, int k) {
        
        List<Tuple<int, int>> tupleList = new List<Tuple<int, int>>();

        for (int i = 0; i < nums1.Length; i++){
            tupleList.Add(new Tuple<int, int>(nums2[i], nums1[i]));
        }

        tupleList.Sort();
        tupleList.Reverse();

        var prioQueue = new PriorityQueue<int, int>();
        long currentSum = 0;

        for (int i = 0; i <= k - 1; i++){
            currentSum += tupleList[i].Item2;
            prioQueue.Enqueue(tupleList[i].Item2, tupleList[i].Item2);
        }

        this.score = currentSum * tupleList[k - 1].Item1;

        for (int i = k; i < nums1.Length; i++){
            currentSum -= prioQueue.Dequeue();
            prioQueue.Enqueue(tupleList[i].Item2, tupleList[i].Item2);
            currentSum += tupleList[i].Item2;
            this.score = Math.Max(this.score, currentSum * tupleList[i].Item1);
        }

        return this.score;
    }
}