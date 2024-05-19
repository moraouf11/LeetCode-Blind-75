// [7,8,5,6] , [1,2,3,4]
public class Solution {  
    public int FindMin(int[] nums) {
        int index = 1; 
            if(nums.Length == 1 || nums[0] < nums.Last())
                return nums[0];        
        while(index +1 < nums.Length)
        {                
            if(nums[index] < nums[index+1] && nums[index] < nums[index-1])
                return nums[index];
            if(nums[index] > nums[index+1] && nums[index] > nums[index-1])
                return nums[index+1];

            if(nums[index] > nums[index-1] && nums[index] < nums[index+1])
                index +=2;  
        }
        return nums[index];

    }
}
