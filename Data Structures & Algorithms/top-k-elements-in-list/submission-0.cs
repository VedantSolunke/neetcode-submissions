public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();

        foreach(int item in nums){
            if(!map.ContainsKey(item)){
                map[item] = 0;
            }
            map[item]++;
        }

        int[] topK = map.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();

        return topK;
    }
}
