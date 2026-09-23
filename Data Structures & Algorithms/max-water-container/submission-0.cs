public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0;

        int left = 0, right = heights.Length-1;

        while(left < right){
            int width = right-left;
            int height = Math.Min(heights[left], heights[right]);

            int area = width * height;
            maxWater = Math.Max(area, maxWater);

            if(heights[left] < heights[right]) left++;
            else right--;
        }

        return maxWater;
    }
}
