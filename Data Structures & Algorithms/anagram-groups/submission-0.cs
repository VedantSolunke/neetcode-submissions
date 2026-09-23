public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new Dictionary<string, List<string>>();

        foreach(var s in strs){
            char[] sArr = s.ToCharArray();
            Array.Sort(sArr);

            string sortedString = new string(sArr);

            if(!result.ContainsKey(sortedString)){
                result[sortedString] = new List<string>();
            }
            result[sortedString].Add(s);
        }

        return result.Values.ToList<List<string>>();
    }
}
