public class Solution {
    public int Search(int[] nums, int target) {
    int left = 0;
    int right = nums.Length - 1;
    int mid=0;
// find the new left values (the minimum value index)
    while (left < right)
    {
        mid = left + (right-left)/2;
        if(nums[mid]== target)
           return mid;
        else if(nums[mid]> nums[right])
            left = mid+1;
        else  
            right = mid ;
    }

// if target is bigger than the minmum and the last index in the array , then we'll search in the 2nd part of the array
    if(target >= nums[left]  && target <= nums[nums.Length - 1]) 
    {   
        right = nums.Length - 1;     
    }
// else , we'll search in the rotated part essentially
    else {
        right = left;     
        left = 0;    
        }

// normal binary search
    while (left <= right)
    {
        mid = left + (right-left)/2;
        if(nums[mid]== target)
           return mid;
        if(nums[mid]< target)
            left = mid+1;
        else right = mid -1;

    }
    return -1; // Element not found    
    }
}
