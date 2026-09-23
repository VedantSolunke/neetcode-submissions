public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length < 2) return nums.Length;

        int count = 1;
        int maxCount = 1;
        var minHeap = new PriorityQueue<int, int>();

        foreach(int n in nums){
            minHeap.Enqueue(n, n);
        }
        int previous = minHeap.Dequeue();
        while(minHeap.Count > 0){
            int current = minHeap.Dequeue();
            if(current == previous) continue;
            if(current == previous + 1){
                count++;
                maxCount = Math.Max(maxCount,count);
            }
            else{
                count = 1;
            }
            previous = current;
        }
        return maxCount;
    }
}
