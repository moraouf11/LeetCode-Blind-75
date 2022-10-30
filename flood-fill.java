class Solution {
    public int[][] floodFill(int[][] image, int sr, int sc, int color) {
       int prev = image[sr][sc];
        if(prev == color)
            return image;
        return floodFillUtil(image, sr, sc, color , prev);
    
    }
    
    public int[][] floodFillUtil(int[][] image, int sr, int sc, int color, int prev) {
        
       if((sr >= image.length) || (sc >= image[0].length) || (sc <0)|| (sr <0))
           /**
 * sr represents rows, sc represents columns
 * but note that when you index a an image, image[row][column], 
 * where [1,1,1],[1,1,0] image means it has two rows and three columns
 * image.length gives me number of arrays in this multi-dim array, meaning 
 * no. of rows, wheres image[0].length gives you first array length , so no. of columns 
 */
        {
            return image;
        }
        
        if(image[sr][sc] != prev){
            return image;
        }

        image[sr][sc] = color;
        floodFillUtil(image, sr+1, sc, color, prev);
        floodFillUtil(image, sr-1, sc, color, prev);
        floodFillUtil(image, sr, sc+1, color, prev);
        floodFillUtil(image, sr, sc-1, color, prev);
        return image;
    
    }
}
