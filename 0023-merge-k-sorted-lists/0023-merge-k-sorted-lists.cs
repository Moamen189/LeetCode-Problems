using System.Collections.Generic;

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var pq = new PriorityQueue<(int val, int i, ListNode node)>((x, y) => x.val.CompareTo(y.val));
        for (int i = 0; i < lists.Length; i++) {
            if (lists[i] != null) {
                pq.Enqueue((lists[i].val, i, lists[i]));
            }
        }
        

        var dummy = new ListNode(0);
        var curr = dummy;
        
        while (pq.Count > 0) {
            var (val, i, node) = pq.Dequeue();
            curr.next = node;
            curr = curr.next;
            if (node.next != null) {
                pq.Enqueue((node.next.val, i, node.next));
            }
        }
        
        return dummy.next;
    }
}
public class PriorityQueue<T> {
    private List<T> data;
    private Comparison<T> compare;

    public PriorityQueue(Comparison<T> compare) {
        this.data = new List<T>();
        this.compare = compare;
    }

    public void Enqueue(T item) {
        data.Add(item);
        int ci = data.Count - 1;
        while (ci > 0) {
            int pi = (ci - 1) / 2;
            if (compare(data[ci], data[pi]) >= 0) {
                break;
            }
            T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
            ci = pi;
        }
    }

    public T Dequeue() {
        int li = data.Count - 1;
        T frontItem = data[0];
        data[0] = data[li];
        data.RemoveAt(li);

        --li;
        int ci = 0;
        while (true) {
            int lix = ci * 2 + 1, rix = ci * 2 + 2;
            if (lix > li) break;
            int mi = lix;
            if (rix <= li && compare(data[rix], data[lix]) < 0) {
                mi = rix;
            }
            if (compare(data[mi], data[ci]) < 0) {
                T tmp = data[ci]; data[ci] = data[mi]; data[mi] = tmp;
                ci = mi;
            } else {
                break;
            }
        }
        return frontItem;
    }

    public int Count {
        get { return data.Count; }
    }
}