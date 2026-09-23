public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();

        foreach(int item in nums){
            if(!map.ContainsKey(item)){
                map[item] = 0;
            }
            map[item]++;
        }

        var minHeap = new PriorityQueue<int, int>();
        foreach(var element in map){
            minHeap.Enqueue(element.Key, element.Value);
            if(minHeap.Count > k){
                minHeap.Dequeue();
            }
        }

        int[] topK = new int[k];
        for(int i=0; i < k; i++){
            topK[i] = minHeap.Dequeue();
        }

        return topK;
    }
}
