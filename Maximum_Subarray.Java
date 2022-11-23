class Solution {
    public int maxSubArray(int[] nums) {
        
        int sum = Integer.MIN_VALUE;
        int naiveSum = 0;
        for ( int i=0; i<nums.length; i++){
            naiveSum += nums[i];
            
            if(naiveSum > sum){
                sum = naiveSum;
            }
            // Kadane’s algorithm Dynamic Programming
            // because this way I start over where if the sum of the next elements 
            // didn't increase over the sum, then I don't need to add it to my sum, and if my sum was negative ,
            // then I before hand have compared the two negative values to get the bigger one, so now I start over to not 
            // add any negative values to my sum.
            if(naiveSum <0)
                 naiveSum =0;
        }
        
        return sum;
    }
}
