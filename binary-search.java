class Solution {
    public int search(int[] nums, int target) {
        int low =0;
        int high = nums.length-1; //5 
        int m = 0;
        int i =1;

        while(low <= high ){
            m = low + (high-low)/2;
            i++;
            if(target == nums[m]){
                return m;
            }
        else if(target > nums[m]){
            low = m+1; 
        }
        else{
            high = m-1;
        }
            }
        return -1;
    }
}
