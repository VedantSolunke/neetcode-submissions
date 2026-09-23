public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();

        foreach(int item in nums){
            if(!map.ContainsKey(item)){
                map[item] = 0;
            }
            map[item]++;
        }

        List<int>[] bucket = new List<int>[nums.Length+1];
        for(int i=0; i < bucket.Length; i++){
            bucket[i] = new List<int>();
        }

        foreach(var entry in map){
            bucket[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for(int i = bucket.Length-1; i > 0 && index < k; i--){
            foreach(var n in bucket[i]){
                res[index++] = n;
                if(index == k) return res;
            }
        }

        return res;
    }
}
