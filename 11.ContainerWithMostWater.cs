public class Solution {
    public int MaxArea(int[] height) {
        int maxArea=0;
        int i=0;
        int j = height.Length-1;
        while(i<j)
        {
            if( height[i] < height[j])
               {
                maxArea= Math.Max(height[i]*(j-i),maxArea) ;
                i++;
                continue;
               }
               else
               {
                maxArea= Math.Max(height[j]*(j-i),maxArea) ;
                j--;
                continue;
               }

        }
        return maxArea;
    }
}
